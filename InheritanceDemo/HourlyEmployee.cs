using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class HourlyEmployee: Employee
    {
        public decimal HourlyRate { get; set; }
        public override string PaySummary
        {
            get { return "This employee is payed " + HourlyRate + " per hour"; }
        }

        public HourlyEmployee():base()
        {
            HourlyRate = 15.0M;
        }

        new public string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }

        new public string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
