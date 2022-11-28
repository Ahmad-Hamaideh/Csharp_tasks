using _28_11_oop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_oop
{
    public class Car
    {
        //private int yearModel;
        //private string make;
        //private int speed;
        //private string color;
        //private string Type;
        //private int Price;
        //private int Pallet_No;
        protected int  year { set; get;  }
        protected string make1 { set; get; }
        protected int  spp { set; get; }
        protected string color1 { set; get; }
        protected string Type1 { set; get; }
        protected int price1 { set; get; }
        protected int pall { set; get; }
         
        public void start () {
            Console.WriteLine(" the car is start  ");
        }
        public void mud()
        {
            Console.WriteLine(" the car is stop  ");
        }
        int y = 0;
        public void lt()
        {
             int xx = Convert.ToInt32(Console.ReadLine());
            int y = xx * 17;
            Console.WriteLine( " - - ->" +" "+y);
        }
        public void sum()
        {
            Console.WriteLine(make1+ "  "+ year+ "  "+ color1 + "  " + Type1 + "  "+ pall + "  " + price1 + "   " + "  "+ spp);
        }
        public  Car(int year, string carMake, int newSpeed, string Clor, string carType, int carprice, int pallet)

        {
            this.year = year;
            this. make1 = carMake;
            this. spp = newSpeed;
            this. color1 = Clor;
            this. Type1= carType;
            this.price1 = carprice;
            this.pall = pallet;


        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car(2012, "Mercedes-Benz S55 AMG ", 280, "black", "xxx", 57000, 2088888);
            c.start();
            Console.WriteLine();
            c.sum();
            Console.WriteLine();
            c.lt();
            Console.WriteLine();
            c. mud();
        }
    }
    public class Car2 : Car
    {

        public Car2(int year, string carMake, int newSpeed, string Clor, string carType, int carprice, int pallet):base(year,carMake,newSpeed,Clor,carType,carprice,pallet)

        {
        


        }
    }
}
