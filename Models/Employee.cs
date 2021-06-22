using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ec.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }
    }
}
