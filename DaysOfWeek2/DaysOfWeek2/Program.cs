using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = " ";
            while (selection != "exit")
            {
                DateTime dt;
                Console.WriteLine("input data:");
                Console.WriteLine("Для выхода введите: exit");
                dt = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(dt.ToString("dddd"));
                Console.ReadKey();
            }
        } 
    } 
}

