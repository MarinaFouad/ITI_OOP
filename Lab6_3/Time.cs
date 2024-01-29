using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    internal class Time
    {
        public Time() { 
            Seconds = 60;
            Minutes = 60;
            Hour = 0; }

        public Time (int seconds , int min , int hour) {
            Seconds= seconds;
            Minutes= min;
            Hour= hour;
        }
        public Time(Time timeCopy) {
            Seconds = timeCopy.Seconds;
            Minutes = timeCopy.Minutes;
            Hour = timeCopy.Hour;
        }

        public int  Seconds { get; set;} 
        public int Minutes { get; set;}
        public int Hour { get; set;}

        public Time sumTime (Time time1 , Time time2)
        {
            
            int sumSec = time1.Seconds + time2.Seconds;
            int sumMinute = time1.Minutes + time2.Minutes;
            int sumHour = time1.Hour + time2.Hour;
            Time sumTimes = new Time();
            sumTimes.Seconds = sumSec;
            sumTimes.Minutes = sumMinute;
            sumTimes.Hour = sumHour;
            return sumTimes;

        }

        public void reset ()
        {
            Seconds = 0;
            Minutes = 0;
            Hour = 0;
            
        }

        public void addMin()
        {
            Minutes = Minutes+ 30;
            while (Minutes >= 60)
            {
                Hour++;
                Minutes = Minutes - 60;
            }
           
        }

        public void timeSeconds()
        {
            
                Seconds=Seconds+ (Minutes*60);
                Seconds=Seconds+ (Hour*3600);
            Minutes = 0; Hour=0;
        }



    }
}
