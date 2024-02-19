namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ComplexNumber complexNumber01 = new ComplexNumber(4,2);
           ComplexNumber complexNumber02 = new ComplexNumber(5,1);
           
           

            ComplexNumber sum = new ComplexNumber();
            sum =complexNumber01 + complexNumber02;
            Console.WriteLine($"Sum = {sum.Real} + J{sum.Img}");

            sum = complexNumber01 - complexNumber02;
            Console.WriteLine($"Sum = {sum.Real} - {sum.Img}J");

            complexNumber01-=complexNumber02;
            Console.WriteLine($"{complexNumber01.Real} + {complexNumber01.Img}J");
        }
    }
}
