namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle01 = new circle();
            Console.WriteLine("Enter radius");
            circle01.Radius= float.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {circle01.Area()} , Perimeter= {circle01.Perimeter()} ");

        }
    }
}
