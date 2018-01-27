using Departments.Departments;
using System;
using System.Collections.Generic;

namespace Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some instances
            var deptMarketing = new Marketing("Marketing", "Elmo", 1, true);
            deptMarketing.AddStrategy("do a giveaway", "reach some new users");

            var deptAccounting = new Accounting("Accounting", "My mom", 3, false);
            deptAccounting.CountMoney("add", "money");

            double baseBudget = 75000.00;

            var agency = new List<Department>
            {
                deptMarketing, deptAccounting
            };

            agency.Add(deptMarketing);
            agency.Add(deptAccounting);

            foreach (Department d in agency)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine($"{d.ToString()}");
                Console.ReadLine();
            }
        }
    }
}

