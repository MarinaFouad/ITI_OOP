using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_5
{
    internal class phonebook
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public phonebook()
        {
            Name= string.Empty;
            PhoneNumber= string.Empty;
        }
        public phonebook(string name, string phoneNumber)
        {
            Name=name;
            PhoneNumber=phoneNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Phone Number: {PhoneNumber}";
        }



    }
}
