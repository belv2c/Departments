using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    // Parent class for all departments
    abstract class Department
    {
        protected string _name;
        protected string _supervisor;
        protected int _employee_count;
        protected bool _isHiring;

        // Constructor method
        public Department(string name, string supervisor, int employees, bool isHiring)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
            _isHiring = isHiring;
        }

        public void AttendMeeting(string meetTime)
        {
            Console.WriteLine($"Come to the meeting at 1:00, or else.");
        }

        public abstract double SetBudget(double budget);
        
    }
}
