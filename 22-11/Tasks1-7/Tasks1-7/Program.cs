using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tasks1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////===Task 1 ===////////////////////////////////////
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "ahmad", "moh", "ali" };
            string[] arr = { "the", "fox", "over", "laze", "dog" };
            ////////////////////===Task 2 ===////////////////////////////////////
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(Array.IndexOf(fruits,"Tomato"));
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            ////////////////////===Task 3 ===////////////////////////////////////
            string[] Food = { "munsf", "Kabsa", "molokhia", "fish", "mandi" };
            string[] Sport = { "footbull", "Tennis", "Basket" };
            string[] Movie = { "Stranger_Things 4", "Wonder", "Don't_Look_Up", "Red Notice" };
            foreach (string i in Food)
            {
                Console.WriteLine(i);
            }
            foreach (string i in Sport)
            {
                Console.WriteLine(i);
            }
            foreach (string i in Movie)
            {
                Console.WriteLine(i);
            }
            ////////////////////===Task 4 ===////////////////////////////////////
            int lol = 2;
            Console.Write("Enter three numbers:");
            string k = Console.ReadLine();
            foreach (char num in k.ToCharArray())
            {
                lol += (int)char.GetNumericValue(num);
            }
            Console.Write("Sum of " + k + " = " + lol);
            Console.ReadKey();
            Console.WriteLine();
            /////////////////Task 4 .2////////////////////////
            Console.WriteLine("Enter 3 numper :");
            int suum = 0;
            string[] vx = Console.ReadLine().Split(',');
            for (int h = 0; h < vx.Length; h++)
            {
                suum += Convert.ToInt32(vx[h]);
            }
            Console.WriteLine(suum);
            ////////////////////===Task 5 ===////////////////////////////////////
            int sum = 0;
            for (int e = 1; e <= 100; e++)
            {
                if (e % 2 != 0)
                {
                    sum += e;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            ////////////////////===Task 6 ===////////////////////////////////////
            for (int i = 0; i <= 4; i++)
            {
                for (int c = 0; c <= i; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ////////////////////===Task 7 ===////////////////////////////////////
            int u = 1;
            for (int n = 0; n < 4; n++)
            {
                for (int p = 0; p <= n; p++)
                {
                    Console.Write(u);
                    u++;
                }
                Console.WriteLine();
            }
            ////////////////////////==== End ====///////////////
        }
    }
}