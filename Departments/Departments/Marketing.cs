using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Departments
{
    public class Marketing : Department
    {

        private Dictionary<string, string> _strategies = new Dictionary<string, string>();


        public Marketing(string dept_name, string supervisor, int employees, bool isHiring) : base(dept_name, supervisor, employees, isHiring)
        {
        }

        // Publicly accessible method to add an HR policy
        public void AddStrategy(string title, string text)
        {
            /*
                Talk about verbose! Every time you want to create, or
                reference a KeyValuePair, you have to use the angle
                brackets, and type keywords.
            */
            _strategies.Add(title, text);

            foreach (KeyValuePair<string, string> strategy in _strategies)
            {
                Console.WriteLine($"In order to {strategy.Value} we first have to {strategy.Key}.");
            }
        }

        // Overriding the default toString() method for each object instance
        public string toString()
        {
            return $"{_name} {_supervisor} {_employee_count}";
        }

    }
}
