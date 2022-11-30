using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _29_11
{
    class Employee
    {
        public string Name { set; get; }
        public int BD { set; get; }
        public int ID { set; get; }





        public Employee(string name, int bd, int iid)
        {
            Name = name;
            BD = bd;
            ID = iid;

        }


        public void Birth(int br )
        {
            Console.WriteLine(2022-br);
        }

        public virtual void Print()
        {
            Console.WriteLine(Name + "  " + BD + "  " + ID);
        }

        public void Birth(int br , int mn)
        {
            Console.WriteLine(2022 - br);
        }



    }


    class manj : Employee
    {
        public manj (string name, int bd, int iid):base (name, bd, iid){

}
        public override void Print()
        {
            Console.WriteLine("welcom ahmad");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Employee opg = new Employee("Ahmad",1800,50);
            opg.Print();
            opg.Birth(1950);
            opg.Birth(1988, 1982);
        }
    }
 
}
