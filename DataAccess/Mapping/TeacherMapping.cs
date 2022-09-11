using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Mapping
{
    public class TeacherMapping : EntityTypeConfiguration<Teacher>
    {
        public TeacherMapping()
        {
            this.HasKey(x => x.ID);

            this.Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(25);

            this.Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(50);


            this.HasRequired(t => t.School)
                .WithMany(s => s.Teachers)
                .HasForeignKey(t => t.SchoolID);
        }
    }
}
