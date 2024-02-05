using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pract02.models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Deparetment { get; set; }
        public long Salary { get; set; }
        public long Phone { get; set; }
    }
}