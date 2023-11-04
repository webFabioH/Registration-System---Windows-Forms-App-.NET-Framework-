using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    class People
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string PhoneNumber {  get; set; }
        public bool OwnHouse { get; set; }
        public bool Vehicle { get; set; }
        public char Gender { get; set; }

    }
}
