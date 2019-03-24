using System;
using System.Collections.Generic;
using System.Text;

namespace Workers_TestTask
{
    class PayByHourWorker : Worker
    {
        public override void СalculateSalary(double ratePerHour)
        {
            Salary = 20.8 * 8 * ratePerHour;
        }
    }
}
