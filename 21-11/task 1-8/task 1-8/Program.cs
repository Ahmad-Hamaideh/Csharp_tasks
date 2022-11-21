using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////// === Task 1 === ////////////////////////////////
            int numper1 = Convert.ToInt32(Console.ReadLine());
            int numper2 = Convert.ToInt32(Console.ReadLine());
            if (numper1 > numper2)
            {
                Console.WriteLine("The biggest number :" + numper1);
            }
            else
            {
                Console.WriteLine("The biggest number :" + numper2);
            }
            /////////////////////////////////// === Task 2 === ////////////////////////////////
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine(" + ");
            }
            else
            {
                Console.WriteLine(" - ");
            }
            ///////////////////////////////////// === Task 3 === ////////////////////////////////
            int lol = Convert.ToInt32(Console.ReadLine());
            int lol2 = Convert.ToInt32(Console.ReadLine());
            int lol3 = Convert.ToInt32(Console.ReadLine());
            if (lol > lol2 && lol > lol3)
            {
                if (lol2 > lol3)
                {
                    Console.WriteLine(lol3 + " " + lol2 + " " + lol);
                }
                else
                {
                    Console.WriteLine(lol2 + " " + lol3 + " " + lol);
                }
            }
            else if (lol2 > lol && lol2 > lol3)
            {
                if (lol > lol3)
                {
                    Console.WriteLine(lol3 + " " + lol + " " + lol2);
                }
                else { Console.WriteLine(lol + " " + lol2 + " " + lol3); }
            }
            if (lol3 > lol2 && lol3 > lol)
            {
                if (lol > lol2)
                {
                    Console.WriteLine(lol2 + " " + lol + " " + lol3);
                }
                else { Console.WriteLine(lol + " " + lol2 + " " + lol3); }
            }
            ///////////////////////////////////// === Task 4 === ////////////////////////////////
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c && a < d && a < e)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c && b < d && b < e)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b && c < d && c < e)
            {
                Console.WriteLine(c);
            }
            else if (d < a && d < b && d < c && d < e)
            {
                Console.WriteLine(d);
            }
            else if (e < a && e < b && e < d && e < c)
            {
                Console.WriteLine(e);
            }
            /////////////////////////////////// === Task 5 === ////////////////////////////////
            Console.WriteLine("Put the kilometer to be converted:");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kilo * 0.621371 + "" + "Mile");
            /////////////////////////////////// === Task 6 === ////////////////////////////////
            Console.WriteLine("Enter the number of hours to be converted");
            int hore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hore * 60 + "" + "m");
            /////////////////////////////////// === Task 7 === ////////////////////////////////
            Console.WriteLine("Put the number of minutes to convert");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m / 60 + "" + "hours" + m % 60 + " " + "minutes");
            /////////////////////////////////// === Task 8 === ////////////////////////////////
            string[] name = { "ahmad", "ali", "mouammad", "nor" };
            Console.WriteLine(name[0].Substring(0, 2) + " " + name[1].Substring(0, 2) + " " + name[2].Substring(0, 2) + " " + name[3].Substring(0, 2) + " ");
        }
    }
}
