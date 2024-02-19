using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class ComplexNumber
    {
        public ComplexNumber() {
            Real = 0;
            Img = 0;
        }
        public ComplexNumber(int real, int img) {
            Real = real;
            Img = img;
        }
        public int Real { get; set; }
        public int Img { get; set; }
        public static ComplexNumber operator+(ComplexNumber num1, ComplexNumber num2)
            {
                return new ComplexNumber
                {
                     Real = num1.Real + num2.Real,
                     Img = num2.Img + num1.Img
                };
            }
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber
            {
                Real = num1.Real - num2.Real,
                Img = num2.Img - num1.Img
            };
        }

        public static ComplexNumber operator -(ComplexNumber num1, int num2)
        {
            return new ComplexNumber
            {
                Real = num1.Real - num2,
                Img = num1.Img
            };
        }
        public static ComplexNumber operator -(int num2, ComplexNumber num1)
        {
            return new ComplexNumber
            {
                Real = num2 - num1.Real,
                Img = num1.Img
            };
        }
        public static ComplexNumber operator -(ComplexNumber num1)
        {
            return new ComplexNumber
            {
                Real = 0- num1.Real ,
                Img = 0- num1.Img
            };
        }

        public static bool operator ==(ComplexNumber num1 , ComplexNumber num2)
        {
            return num1.Real == num2.Real && num1.Img == num2.Img;
            
        }
        public static bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Real != num2.Real || num1.Img != num2.Img;

        }

        public static bool operator >(ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Real > num2.Real || num1.Img > num2.Img;

        }
        public static bool operator >=(ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Real >= num2.Real || num1.Img >= num2.Img;

        }

        public static bool operator <(ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Real < num2.Real || num1.Img < num2.Img;

        }
        public static bool operator <=(ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Real <= num2.Real || num1.Img <= num2.Img;

        }

        public static implicit operator int(ComplexNumber num1)
        {
            return (int)(num1.Real+num1.Img);
        }

        public static implicit operator string(ComplexNumber num1)
        {
            return $"{num1.Real} + {num1.Img}";
        }

        public static implicit operator bool(ComplexNumber num1)
        {
            return (num1.Real != 0 || num1.Img != 0);
            

        }







    }
}
