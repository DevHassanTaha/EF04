using EF02_Demo.ConfigurationsModel;
using EF02_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDbGo1;trusted_connection=true;trustservercertificate=true;")
            .UseLazyLoadingProxies(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<User>()
                        .HasOne(u => u.UserProfile)
                        .WithOne(u => u.User)
                        .HasForeignKey<UserProfile>(u => u.FKUserId);


            modelBuilder.Entity<Category>()
                        .HasMany(x => x.Products)
                        .WithOne(x => x.Category)
                        .HasForeignKey(x => x.CategoryId);
            //modelBuilder.Entity<Course>()
            //    .HasMany(x => x.students)
            //    .WithMany(x => x.Courses);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(x => new { x.StudentId, x.CourseId });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


    }
}
