using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_5
{
    internal class EditPhoneBook
    {
        
        public phonebook[] contacts;
        public int currentIndex;
        int size = 150;

        public EditPhoneBook()
        {
            contacts = new phonebook[size];
            currentIndex = 0;
        }

        public void AddContact(phonebook contact)
        {
            if (currentIndex < size)
            {
                contacts[currentIndex] = contact;
                currentIndex++;
            }
            else
            {
                Console.WriteLine(" Can't add contacts.");
            }
        }

       
        public phonebook this[int index]
        {
            get
            {
                if (index >= 0 && index < currentIndex)
                {
                    return contacts[index];
                }
                
              throw new IndexOutOfRangeException("Invalid index");
                
            }
        }

        
    }
}
