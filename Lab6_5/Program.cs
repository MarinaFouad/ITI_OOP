namespace Lab6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EditPhoneBook phoneBook01 = new EditPhoneBook();

            phonebook contact01 = new phonebook("Marina", "0123455");
            phonebook contact02 = new phonebook("Ahmed", "893819389");

            phoneBook01.AddContact(contact01);
            phoneBook01.AddContact(contact02);

          
            Console.WriteLine("contact 1 :  ");
            Console.WriteLine(phoneBook01[0]);
        }
    }
}
