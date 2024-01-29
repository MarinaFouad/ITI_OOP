namespace Lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time01 = new Time(20,30,3);
            Time time02 = new Time(30,20,4);
            Time Sum1 = new Time();
            Sum1.sumTime(time01,time02);
            Console.WriteLine($"seconds {Sum1.Seconds} ,, Min = {Sum1.Minutes} ,, Hour = {Sum1.Hour}");
            Sum1.reset();
            Console.WriteLine($"seconds {Sum1.Seconds} ,, Min = {Sum1.Minutes} ,, Hour = {Sum1.Hour}");

            time01.addMin();
            Console.WriteLine($"seconds {time01.Seconds} ,, Min = {time01.Minutes} ,, Hour = {time01.Hour}");
            time01.timeSeconds();
            Console.WriteLine($"seconds {time01.Seconds} ,, Min = {time01.Minutes} ,, Hour = {time01.Hour}");

        }
    }
}
