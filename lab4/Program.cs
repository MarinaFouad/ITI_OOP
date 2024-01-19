using System.Threading.Channels;
using System;
using System.Timers;


namespace lab4
{
    internal class Program
    {
        //globel arrays to be seen in all functions

       static string[] arr1 = new string[3], arr2 = new string[3], arr3 = new string[3];
       static string[] arr4 = new string[3], arr5 = new string[3];
        static void Main(string[] args)
        {
            
            Emp(arr1);
            Emp(arr2);
            Emp(arr3);
            Emp(arr4);
            Emp(arr5); 

            var timer = new System.Timers.Timer(10000); ;
            timer.Elapsed += OnTimedEvent;
            timer.Start();

            Console.WriteLine("Timer started. Press Enter to exit.");
            Console.ReadLine(); 
            timer.Stop();
        }

        //to Enter Infoo
        #region Enter Employee Info Function
        static void Emp (string[] arr)
        {
            Console.WriteLine("Enter your name");
            arr[0] = Console.ReadLine();
            Console.WriteLine("Enter your salary");
            arr[1] = Console.ReadLine();
            Console.WriteLine("ID");
            arr[2] = Console.ReadLine();

            Console.WriteLine("Done Employee");
        }
        #endregion
        // executed at the end of Timer 


        #region After timer
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            printEmployee(arr1);
            printEmployee(arr2);
            printEmployee(arr3);
                
            printEmployee(arr4);
            printEmployee(arr5);

        }
        #endregion

        ///To Print infooo

        #region Print Employee Info Function
        public static void printEmployee(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion
    }




    #region Difference between string and StringBuiler

    //StringBuiler faster than string 
    //ynf3 n3ml append 3la StringBuiler 
    //3ashan nzawd 3la string bn3ml kda str+= " " 
    //use StringBuiler lma n7b n3'air feha kter , string btkon constant aktr 
    #endregion
}
