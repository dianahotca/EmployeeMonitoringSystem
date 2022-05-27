using Model;
using System;
using System.Data.Entity;

namespace Persistence
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskEmployee> TaskEmployees {get;set;}

        public EmployeeContext()
        {
            Database.Log = Console.WriteLine;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .HasMaxLength(128);

            modelBuilder.Entity<User>()
                .HasKey(x=> x.Username);

            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<Task>().HasKey(x => x.Id);

            modelBuilder.Entity<Boss>().ToTable("Bosses");
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<TaskEmployee>().HasKey(x => new { x.TaskId, x.Username });
            modelBuilder.Entity<TaskEmployee>().HasRequired(x => x.Task);
            modelBuilder.Entity<TaskEmployee>().HasRequired(x => x.Employee);

            base.OnModelCreating(modelBuilder);
        }
    }
}
