using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Departments
{
    class Marketing : Department
    {
        public Marketing(string dept_name, string supervisor, int employees, bool isHiring) : base(dept_name, supervisor, employees, isHiring){}

        private Dictionary<string, string> _strategies = new Dictionary<string, string>();

        private double Budget;

        
        // Publicly accessible method to add a marketing strategy
        public void AddStrategy(string title, string text)
        {
            _strategies.Add(title, text);


            foreach (KeyValuePair<string, string> strategy in _strategies)
            {
                Console.WriteLine($"In order to {strategy.Value} we first have to {strategy.Key}.");
            }
        }

        public void AttendMeeting(string meetTime, bool isOntime)
        {
            if(isOntime)
            {
                Console.WriteLine($"Great job! You made it.");
            }
                Console.WriteLine($"You're probably getting fired.");
        }

        public override double SetBudget(double budget) => Budget += budget + 23234.00;

    }
}
