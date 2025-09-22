using EF02_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.ConfigurationsModel
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DepId);
            builder.Property(x => x.DepId)
                   .UseIdentityColumn(10, 10);

            //builder.Property(x => x.DepId)
            //       .ValueGeneratedNever();

            //builder.Property(x => x.DepId)
            //       .HasDefaultValueSql("NewGuid");

            builder.Property(x => x.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .HasColumnName("DepartmentName")
                   .IsRequired(false)
                   .HasDefaultValue("HR");

            builder.Property(x => x.DateOfCreation)
                   .HasAnnotation("DateType", "Date")
                   //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))
                   .HasDefaultValueSql("GetDate()");

            builder.Ignore(x => x.Serial);

            builder.HasData(
                new Department {DepId = 10, Name = "HR", DateOfCreation = DateTime.Now },
                new Department {DepId = 20, Name = "PR", DateOfCreation = DateTime.Now },
                new Department {DepId = 30, Name = "Sales", DateOfCreation = DateTime.Now }
                );

        }
    }
}
