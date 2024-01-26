using System.Threading.Channels;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book01 = new Book();
           visitor visitor01 = new visitor();

            Console.WriteLine("Enter book name");
            book01.Name = Console.ReadLine();
            Console.WriteLine("Enter Auther name");
            book01.Auther = Console.ReadLine();
            Console.WriteLine("Enter Edition");
            book01.Edition = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category");
            book01.Category = Console.ReadLine();

            Console.WriteLine("Enter your name");
            visitor01.Name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            visitor01.Email = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            visitor01.Phone = int.Parse(Console.ReadLine());
           


        }
    }
}
