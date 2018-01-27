using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Departments
{
    class Accounting : Department
    {
        private Dictionary<string, string> _counting = new Dictionary<string, string>();
        private double Budget;

        public Accounting(string dept_name, string supervisor, int employees, bool isHiring) : base(dept_name, supervisor, employees, isHiring)
        {
        }

        public void CountMoney(string title, string text)
        {

            _counting.Add(title, text);

            foreach (KeyValuePair<string, string> count in _counting)
            {
                Console.WriteLine($"This week we really need to {count.Key} all the {count.Value}.");
            }
        }

        public override double SetBudget(double budget) => Budget += budget + 20000.00;
    
    }
}
