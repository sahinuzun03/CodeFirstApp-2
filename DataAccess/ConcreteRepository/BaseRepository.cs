
using DataAccess.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class BaseRepository<T> where T : class, IBaseEntity
    {
        private readonly EtutDbContext _etutDbContext;
        private DbSet<T> _table;

        public BaseRepository(EtutDbContext etutDbContext)
        {
            _etutDbContext = etutDbContext;
            _table = _etutDbContext.Set<T>();
        }
        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;

        }

        public bool AddRange(List<T> entities)
        {
            _table.AddRange(entities);
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.status = Status.Deleted; //Gelen entity'nin tipini Silinmişe çektim.
            return Update(entity);

        }

        public List<T> GetAll()
        {
            return _table.Where(x => x.status == Status.Active || x.status == Status.Modified) .ToList(); //Statusu Active olanları getir
        }

        public T GetByID(int id)
        {
            return _table.Find(id);
        }

        public int Save()
        {
            return _etutDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _etutDbContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }
    }
}
