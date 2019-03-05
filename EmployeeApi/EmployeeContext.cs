using EmployeeApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john.smith@gmail.com",
                    Mobile = "1112223333",
                    Company = "UFCU",
                    Address = "123 Dairy Ln.",
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Mike",
                    LastName = "Jacobs",
                    Email="mike.jacobs@gmail.com",
                    Mobile="4445556666",
                    Company = "Bank of America",
                    Address = "456 Corporate Dr."
                });
        }

    }
}
