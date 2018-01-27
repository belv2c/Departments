using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Departments
{
    class AccountingEmployee : IFullTime
    {
        private double _vacationTime;

        public double VacationTime
        {
            get { return _vacationTime; }
            set
            {
                if (value >= 40 && value <= 100)
                {
                    _vacationTime = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cannot set vacation time to value specified");
                }
            }
        }
    }
}
