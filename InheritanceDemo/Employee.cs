using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string PaySummary { get; set; }

        public virtual string GetPaySummary()
        {
            return "No pay for base class employee";
        }

    }
}
