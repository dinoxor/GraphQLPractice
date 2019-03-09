using EmployeeApi.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(a => a.EmployeeId);
            Field(a => a.FirstName);
            Field(a => a.LastName);
            Field(a => a.Email).Description("Full email");
            Field(a => a.Mobile);
            Field(a => a.Company);
            Field(a => a.Address);
            Field(a => a.ShortDescription);
        }
    }
}
