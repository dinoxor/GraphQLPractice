using EmployeeApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
    }
}
