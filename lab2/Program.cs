namespace lab2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Squere Area

            Console.WriteLine("Enter the length ");
            int length = int.Parse(Console.ReadLine());
            int Area = length * length;
            Console.WriteLine($"Enter the length {Area} ");
            #endregion

            #region Age
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age);
            #endregion

            #region Name and age 
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            int userAge = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"hello {name} , your age is {userAge}");
            #endregion
        }
    }
}
