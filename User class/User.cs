using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_class
{
    internal class User
    {
        public User(string firstname, string lastname, byte age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte Age { get; set; }
    }
}
