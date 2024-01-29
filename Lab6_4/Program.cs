using static Lab6_4.EnumClass;

namespace Lab6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seasonName = Console.ReadLine();

            EnumClass.Eseasons selectedSeason = (EnumClass.Eseasons)EnumClass.Parse(typeof(EnumClass.Eseasons), seasonName, true);

            switch (selectedSeason)
            {
                case EnumClass.Eseasons.summer:
                    Console.WriteLine("Month Range: June to August");
                    break;
                case EnumClass.Eseasons.winter:
                    Console.WriteLine("Month Range: December to February");
                    break;
                case EnumClass.Eseasons.spring:
                    Console.WriteLine("Month Range: March to May");
                    break;
                case EnumClass.Eseasons.automn:
                    Console.WriteLine("Month Range: September to November");
                    break;
            }
        }
    }
}
