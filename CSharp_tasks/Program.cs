using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user Name :");
            string username=Console.ReadLine();
            Console.WriteLine("Ueser Name is" + username);

            /////////////////////////////////////////////

            string name = "ahmad";
            int numper = 91;
            char x = 'a';
            bool y = false;
            const string nam = "ali";
            double r = 1.5;

            Console.WriteLine( name);
            Console.WriteLine(numper);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(nam); 
            Console.WriteLine(r);

            //////////////////////////////////////////////

            string[] cars = { "Mercedes Benz", "BMW", "Cadillac", "HONDA" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            ///////////////////////////////////////////////

            Console.WriteLine("Enter user Name :");
            string user = Console.ReadLine();
            Console.WriteLine("Enter last Name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();

            Console.WriteLine(user + " " +lname+ " " +age);

            ///////////////////////////////////////

            int [] nuum = { 12, 13, 14, 15, 16, 17, 11, 22, 27, 88 };

            Console.WriteLine(nuum[0]);
            Console.WriteLine(nuum[1]);
            Console.WriteLine(nuum[2]);
            Console.WriteLine(nuum[3]);
            Console.WriteLine(nuum[4]);
            Console.WriteLine(nuum[5]);
            Console.WriteLine(nuum[6]);
            Console.WriteLine(nuum[8]);
            Console.WriteLine(nuum[7]);
            Console.WriteLine(nuum[9]);

            int sum = nuum[0] + nuum[1];
            Console.WriteLine(sum);

            //////////////////////////////////////


        }
    }
}



