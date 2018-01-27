using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Departments
{
    class MarketingEmployee : IPartTime
    {
        private string _vacationTime;

        public string VacationTime
        {
            get { return _vacationTime; }
            set => Console.WriteLine($"You are a part-time employee. You get no vacation, sorry.");
        }
    }
}
