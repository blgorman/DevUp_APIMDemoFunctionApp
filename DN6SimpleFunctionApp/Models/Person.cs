using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN6SimpleFunctionApp.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
