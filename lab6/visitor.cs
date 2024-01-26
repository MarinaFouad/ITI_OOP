using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class visitor
    {
        int phone;
        string email, name;

        
        public string Email { get { return email; } set { email = value; } }

        public int Phone { get { return phone; } set { phone = value; } }
        public string Name { get { return name; } set { name = value; } }
 
        public visitor() { }
        public visitor(int phone, string email, string name)
        {
            this.phone = phone;
            this.email = email;
            this.name = name;
        }
        public visitor (visitor visitCopy)
        {
            this.phone = visitCopy.phone;
            this.email = visitCopy.email;
            this.name = visitCopy.name;
        }



    }
}
