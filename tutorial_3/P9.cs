using System;
using tutorial3;

namespace tutorial3
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        //constructor
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }
        //parameterized constructor
        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }
        //method to increment second
        public void IncrementSecond()
        {
            sec++;
            if (sec >= 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;

                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        //method to display time
        public void Display()
        {
          
            Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }

    }

    class P9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Clock c = new Clock(10, 59, 59);
            Console.WriteLine("Current Time");
            c.Display();

            c.IncrementSecond();

            Console.WriteLine("After Incrementing Second");
            c.Display();

        }

    }
}