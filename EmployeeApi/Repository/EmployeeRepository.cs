using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //private readonly EmployeeContext _context;
        //public EmployeeRepository(EmployeeContext context)
        //{
        //    _context = context;
        //}

        private readonly GraphQLDemoContext _context;
        public EmployeeRepository(GraphQLDemoContext context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployees()
        {
            return _context.Employee.ToListAsync();
        }
    }
}
