using GraphQL;
using GraphQL.Types;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var schema = new Schema
            {
                Query = new StarWarsQuery()
            };

            var json = schema.Execute(_ =>
           {
               _.Query = "{hero {name id}}";
           });

            Debug.WriteLine(json);
        }
    }
}
