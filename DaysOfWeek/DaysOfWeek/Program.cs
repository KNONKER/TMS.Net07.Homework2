using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        public enum DaysOfWeek
        {
            понедельник = 1,
            вторник = 2,
            среда = 3,
            четверг = 4,
            пятница = 5,
            суббота = 6,
            воскресенье = 7
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Input day of week:");
            var flag = true;
            while (flag)
            {
                var num = Console.ReadLine();
                switch (num)
                {
                    case "monday":
                        Console.WriteLine(DaysOfWeek.понедельник);
                        break;
                    case "tuesday":
                        Console.WriteLine(DaysOfWeek.вторник);
                        break;
                    case "wednesday":
                        Console.WriteLine(DaysOfWeek.среда);
                        break;
                    case "thursday":
                        Console.WriteLine(DaysOfWeek.четверг);
                        break;
                    case "friday":
                        Console.WriteLine(DaysOfWeek.пятница);
                        break;
                    case "saturday":
                        Console.WriteLine(DaysOfWeek.суббота);
                        break;
                    case "sunday":
                        Console.WriteLine(DaysOfWeek.воскресенье);
                        break;
                    case "exit":
                        flag = false;
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}