using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Book
    {
        string name, auther ,category;
        int edition;

 

        public string Name
        {
            get { return name; }
            set{  name = value; }
        }
        public int Edition
        { get { return edition; } 
          set {  edition = value; } }
        public string Category
        { get { return category; } 
          set {  category = value; } }

        public string Auther
        {
            get { return auther; }
            set { auther = value; }
        }
        public Book() { }
        public Book(string name, string auther, string category, int edition)
        {
            this.name = name;
            this.auther = auther;
            this.category = category;
            this.edition = edition;

        }
        public Book(Book BookCopy)
        {
            this.Name = BookCopy.Name;
            this.auther = BookCopy.Auther;
            this.category = BookCopy.Category;
            this.edition = BookCopy.edition;
        }
    }
}
