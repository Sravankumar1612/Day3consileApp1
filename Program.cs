using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Monthsofyear { jan = 1, feb = 2, mar = 3 }
        static void Main(string[] args)
        {
            Console.WriteLine("First Month: \t " + (int)Monthsofyear.jan);
            Console.WriteLine("Second Month: \t" + Monthsofyear.feb);
            Console.ReadKey();
            //byte myByte = 12;
            //sbyte myByte2 = 13;
            //short mySShort = 12;
            try
            {
                byte ourByte;
                Console.WriteLine("Enter a number");

                ourByte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Nuber is " + ourByte);
            }
            catch (FormatException ex) { Console.WriteLine("Format exception : "+ex); }
            catch (OverflowException oe) { Console.WriteLine("Overflow exception"+oe); }
            catch (Exception e) { Console.WriteLine("Error : " + e); }
            finally { Console.WriteLine("End of Program"); }
            Console.ReadKey();
        }
    }
}
