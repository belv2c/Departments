using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    public class Department
    {// Parent class for all departments
            private string _name;
            private string _supervisor;
            private int _employee_count;

            // You can create properties, if needed

            // Constructor method
            public Department(string name, string supervisor, int employees)
            {
                _name = name;
                _supervisor = supervisor;
                _employee_count = employees;
            }
        }
    }
