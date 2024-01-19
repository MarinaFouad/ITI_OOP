namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region checkEven
/*
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 ) { 
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is Even",num);

                }
                else
                {
                    Console.WriteLine("{0} is ODD", num);
                }
            }

*/
            #endregion


            #region grades
/*
            Console.WriteLine("Enter 5 students grades");
            int sum = 0;
            for(int i=0; i<5; i++)
            {
                int grade = int.Parse(Console.ReadLine());
                sum += grade;
            }
            Console.WriteLine("Sum of the grades = {0}", sum);
*/
            #endregion


            #region number sum
            /*  Console.WriteLine("Enter 10 numbers");
              int evenSum = 0;
              int oddSum = 0;
              for (int i = 0; i < 10; i++)
              {
                  int enteredNum = int.Parse(Console.ReadLine());
                  if(enteredNum %2==0 )
                  {
                      evenSum += enteredNum;
                  }
                  else
                  {
                      oddSum += enteredNum;
                  }

              }
              Console.WriteLine($"the odd sum = {oddSum}");
              Console.WriteLine($"the even sum = {evenSum}");
            */
            #endregion

            /*
            #region socks Example

            Console.WriteLine("Enter number of red socks");
            int red = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of blue socks");
            int blue = int.Parse(Console.ReadLine());

            if (red > blue)
            {
                Console.WriteLine("Number of dress fashionable = {0}", blue);
                int diff = red - blue;

                Console.WriteLine("red={0}", diff / 2);

            }
            else
            {
                Console.WriteLine("Number of dress fashionable = {0}", red);
                int diff = blue - red;

                Console.WriteLine("blue={0}", diff / 2);
            }


            #endregion
*/
            int x = 0;
            add(x);
            Console.WriteLine(x);
        }

        static void add(int x)
        {
            x++;
        }
    }
}
