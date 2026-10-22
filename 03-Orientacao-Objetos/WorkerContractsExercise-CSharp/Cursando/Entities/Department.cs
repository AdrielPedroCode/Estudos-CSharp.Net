using System;
using System.Collections.Generic;
using System.Text;

namespace Cursando.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        Department()
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
