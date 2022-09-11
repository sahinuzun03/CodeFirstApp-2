using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class EtutDbContext : DbContext
    {
        public EtutDbContext() : base("Server=DESKTOP-7628CQK;Database=EtutDbDatabase;Uid=sa;Pwd=11411141;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EtutDbContext>());
        }
        
        public DbSet<Teacher> Teachers { get; set; }    

        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SchoolMapping());
            modelBuilder.Configurations.Add(new TeacherMapping());
        }
    }
}
