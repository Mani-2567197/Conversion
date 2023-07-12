using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int num;
            Console.WriteLine("TryParse Method");
            if (int.TryParse(str, out num))
            {
                Console.WriteLine("Tryparse:\t" + num * 5);
            }
            else
            {
                Console.WriteLine("Invalid string format");
            }

            Console.WriteLine();
            string str1;
            Console.WriteLine("Enter the string");
            str1 = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(str1);
                Console.WriteLine("Converting string to date");
                Console.WriteLine("Converted date:\t" + date);
                Console.WriteLine("After subtract one month from obtained date:\t" + date.AddMonths(-1));
            }
            catch (FormatException f)
            {
                Console.WriteLine("Invalid format  :" + f.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string str2;
            Console.WriteLine("Enter the string");
            str2 = Console.ReadLine();
            try
            {
                Console.WriteLine("Converting string to timespan");
                TimeSpan ts = TimeSpan.Parse(str2);
                Console.WriteLine("Time span:" + ts);
                TimeSpan ts2 = new TimeSpan(2, 0, 0);
                TimeSpan ts1 = ts.Add(ts2);
                Console.WriteLine($"Total duration {ts1.Hours}:Hours {ts1.Minutes}:Minutes {ts1.Seconds}:seconds ");
            }
            catch (FormatException f2)
            {
                Console.WriteLine("Invalid format  :" + f2.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
                Console.ReadKey();

            }
        }
    }
}
