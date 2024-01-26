using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class circle
    {
        public circle() { Radius = 1; }
        public circle(int radius) { Radius = radius;}

        public circle(circle circleCopy) {  Radius = circleCopy.Radius;}
        const float pi = 3.14f;
        public float Radius { get;  set; }

        public float Area() { return Radius*Radius*pi; }

        public float Perimeter() { return Radius * 2* pi; }

    }
}
