using EmployeeApi.Repository;
using System;

namespace GraphQLConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository(new EmployeeApi.GraphQLDemoContext());

            var employees = employeeRepository.GetEmployees();

            //foreach (var employee in employees)
            //{
            //    Debug.WriteLine(employee.FirstName);

            //}
        }
    }
}
