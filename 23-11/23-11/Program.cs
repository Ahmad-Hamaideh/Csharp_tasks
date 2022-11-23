using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_11
{
    internal class Program
    {
        ////////===task 1===//////////
        static void mynum()
        {
            string[] lol = Console.ReadLine().Split(',');
            int[] num2 = new int[lol.Length];
            int sum = 0;
            for (int i = 0; i < lol.Length; i++)
            {
                num2[i] = Convert.ToInt32(lol[i]);
                sum += num2[i];
            }
            Console.WriteLine( "sum =" + sum);
            Console.WriteLine( "avrej =" +  sum / num2.Length);
            Console.WriteLine("============= Task 2 ===============");
        }
        /////////=== task 2 === ////////////
        static void cup()
        {
            string[] cupp = Console.ReadLine().Split(',');
            int[] cu = new int[cupp.Length];
            int cu2 = 0;
            for (int i = 0; i < cu.Length; i++)
            {
                cu[i] = Convert.ToInt32(cupp[i]);
                cu2 = cu[i];
                Console.WriteLine("Cubic number : " + cu2 * cu2 * cu2);
               
            } Console.WriteLine("======================================= Task 3 ===============");
        }

        ////=== task 3 === ////////////////
        static void age() {
            int[] x = { 1977, 1944, 1988, 1956, 1991, 1923, 1968 };
            for (int i = 0; i<x.Length;i++) {
                if (x[i] > 1950)
                {
                    Console.WriteLine(x[i]);
                }
            }
            Console.WriteLine("======================================= Task 4 ===============");
        }
        //// === task 4 ===//////////
        static void ok ()
        {
            Console.WriteLine(" put age in year :");
                int y = Convert.ToInt32(Console.ReadLine());
            int age = y * 365;
            Console.WriteLine("Your age in days : " + age);
            /////// === task 5 === ////////
            Console.WriteLine("======================================= Task 5 ===============");
        }
        static void anmail()
        {
            Console.WriteLine("Put in the number of chickens you have :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Put in the number of cows you have :");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Put in the number of Sheep you have :");
            int a3 = Convert.ToInt32(Console.ReadLine());

            int sum1 = a1 * 2;
            int sum2 = a2 * 4;
            int sum3 = a3 * 4;
            int dl = sum1 + sum2 +sum3;
            Console.WriteLine(" your legs anamil : " + " --> "+dl );
            Console.WriteLine("======================================= Task 6 ===============");
        }
        /////=== task 6 === //////
        static void task(string[] user, string[]pass)
        {
            Console.WriteLine( "User :" );

            for (int i=0; i < user.Length; i++)
            {
                string use =Console.ReadLine();
                string pas =Console.ReadLine();
                if(use == user[i] && pas == pass[i])
                {
                    Console.WriteLine("pass ");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
         

        }
            //// task 7 
             static int powr (int i ,int j)
        {
            int sum = i;
            for (int k=1; k<j; k++)
            {
                sum *= i;
            }
            return
                sum;
    
           }
        /////
         static bool leep( int year)
        {
          for(int i=1900; i<= 2024; i += 4)
            {
             if (year==i)
                {
                      return true;   
                }

            }

        return false;

                
        }
        static void prim()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine("false");
            }

            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("false");
                    break;
                }
                else
                {
                    Console.WriteLine("true");
                    break;
                }
            }
        
        }
        ////////////////// task 9 
          static int numperr(string words)
        {
            int n = 0;
            foreach(char i in words) {
            if(i == ' ')
                {
                    continue;
                }
            n++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            mynum();  // task 1
            cup();   //  task 2
            age();  //   task 3
            ok();   //    task 4
            anmail();  //   task 5
            string[] users = { "ahmad", "ali", "omer" };
            string[] password = { "222", "245,101" };      // =======> task 6
            task(users, password);


            ////=================== task 7 ==========================
            Console.WriteLine("======================================= Task 7 ===============");
            Console.WriteLine("power --->" + "   " + powr(5, 3));


            ////////////// 8

            Console.WriteLine("======================== task 8 =============");
            Console.WriteLine("enter your 1900 - 2024");
            int leap = Convert.ToInt32(Console.ReadLine());
          
                bool yy =leep(leap);
            if (yy)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap");
            }

            ////=================== task 9 ==========================
            Console.WriteLine("======================================= Task 9===============");
            prim();     // task 9

            ////=================== task 9 ============================
            Console.WriteLine("======================================= Task 10 ===============");
            Console.WriteLine("enter sentes to know char in it :");
            string word = Console.ReadLine();
            int count = numperr(word);
            Console.WriteLine($"the numer of chars : {count}");



        }
    }
}
