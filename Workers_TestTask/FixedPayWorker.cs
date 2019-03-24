using System;
using System.Collections.Generic;
using System.Text;

namespace Workers_TestTask
{
    class FixedPayWorker : Worker
    {
        public override void СalculateSalary(double averageMonthlySalary)
        {
            Salary = averageMonthlySalary;
        }
    }
}
