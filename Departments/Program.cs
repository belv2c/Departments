using Departments.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            // Create some instances
            var deptMarketing = new Marketing("Marketing", "Elmo", 1, true);
            deptMarketing.AddStrategy("do a giveaway", "reach some new users");

            // Add derived departments to the list
            departments.Add(deptMarketing);

            // Iterate over all items in the list and output a string 
            // representation of the class
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.ToString()}");
                Console.ReadLine();
            }
        }

    }
}

