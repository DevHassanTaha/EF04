using InhertinceMapping.Models;
using Microsoft.EntityFrameworkCore;


namespace EF02_Demo.Contexts
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmployeeDbGo1;trusted_connection=true;trustservercertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<string>("EmployeeType")
            //    .HasValue<FulltimeEmployee>("FullTime")
            //    .HasValue<ParttimeEmployee>("PartTime");


            //modelBuilder.Entity<FulltimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<ParttimeEmployee>().HasBaseType<Employee>();

            modelBuilder.Entity<FulltimeEmployee>().ToTable("FulltimeEmployees");
            modelBuilder.Entity<ParttimeEmployee>().ToTable("ParttimeEmployees");



            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FulltimeEmployee> FulltimeEmployees { get; set; }
        public DbSet<ParttimeEmployee> ParttimeEmployees { get; set; }


    }
}
