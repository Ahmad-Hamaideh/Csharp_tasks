using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11
{

    class Person
    {


        private double age;
        private string gender;
        public string name;
        private string email;
        private int id;
        private string phone;

        public void check_age(int age)
        {
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("- - - - - - > Welcome to our site, dear"); 
                
            }
            else
            {
                Console.WriteLine("- - - - - - > Sorry, your age is not supported");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void check_gender(string gender)
        {
            if (gender == "female")
            {
                Console.WriteLine("- - > your gender : female");

            }
            else
            {
                Console.WriteLine(" - - > your gender : male");
                
            }
          


        }


        public void check_name(string n)
        {
            name = n;
            Console.WriteLine( "wellcome Dear  "+"  "+ name);
        }


        public void check_email(string e)
        {

            email = e;
            Console.WriteLine("your email : " + email);
        }

        public void check_phone(string p)
        {

            phone = p;
            string s = phone.Substring(0, 3);
           
            if (s == "078" || s == "079" || s == "077" && s.Length >= 10)
            {
                Console.WriteLine("your phone :" + phone);
               
            }


            else
            {
                Console.WriteLine();
                Console.WriteLine("please enter valid phone number 077 or 078 or 079" ); 
            }
        }


        public void print_id(int i)
        {
            id = i;
            Console.WriteLine( "your Id :" + id);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(" - - - - -  - - - - - - - - -  - - - - - - - - - Welcome dear to our website - - - - - - - -  - - - - -");
            Console.WriteLine();
            Console.WriteLine();

            Person lol = new Person();

            Console.WriteLine("------------ print Name --------------- ");

            Console.WriteLine("please enter your Name :");
            string your_name = Console.ReadLine();
            lol.check_name(your_name);




            Console.WriteLine();
            Console.WriteLine(" --------- check your age ---------");
            Console.WriteLine();
            Console.WriteLine("please enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            lol.check_age(age);

            Console.WriteLine("---------- check your gender ----------- ");

            Console.WriteLine("please enter your gender");
            string gender = Console.ReadLine();
            lol.check_gender(gender);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine(" ----------- print Email ------------- ");

            Console.WriteLine("please enter your EMAIL");
            string your_email = Console.ReadLine();
            lol.check_name(your_email);

            Console.WriteLine();

            Console.WriteLine(" ----------- put your phone --------------- ");

            Console.WriteLine("please enter your PHONE");
            string phone = Console.ReadLine();
            lol.check_phone(phone);

            Console.WriteLine();


            Console.WriteLine(" ------------ put your  ID ----------");

            Console.WriteLine("please enter your ID");
            int id = Convert.ToInt32(Console.ReadLine());
            lol.print_id(id);

            Console.WriteLine();
            Console.WriteLine(" - -- - - - -- - - your information : - - - - -- - - - - -");
            Console.WriteLine();
            Console.WriteLine("your name :" + your_name + "\n" + " your age :  " + age + "\n " + "your phone : " + phone + "\n" + "your id : " + id);


        }
    }
}