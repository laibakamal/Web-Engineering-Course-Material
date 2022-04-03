// TASK 1

using System;
using System.IO;
namespace Lab1
{
    class program
    {
        static void Main(string[] args)
        {
            int X=Convert.ToInt32(args[0]);
            int N = Convert.ToInt32(args[1]);

            for (int i = X, j = 1; j <= N; j++)
            {
                Console.Write(i * j);
                Console.Write(" ");
            }
        }
    }

}

//---------------------------------------------------------------------------------------------




//TASK 2


using System;
using System.IO;
namespace Lab1
{
    class program
    {
        static void sendEmail(string msg, string to, string cc = "", bool attach = false)
        {
            Console.Write(msg);
            Console.Write("\n");
            Console.Write(to);
            Console.Write("\n");
            Console.Write(cc);
            Console.Write("\n");
            Console.Write(attach);
        }

        static void Main(String[] args)
        {
            sendEmail("This is a message.", "bsef19m003@pucit.edu.pk");
        }
    }

}


//---------------------------------------------------------------------------------------------



//TASK 3

using System;
namespace Lab1
{
    class program
    {
        static void calculateGPA(params int[] grades)
        {
            double GPA = 0;
            foreach (int i in grades)
            {
                GPA = GPA + i;
            }
            int l = grades.Length;
            GPA /= l;
            Console.Write(GPA);
        }
        static void Main(String[] args)
        {
            calculateGPA(56, 78, 85, 90, 76);
        }

    }
}


---------------------------------------------------------------------------------------------

//TASK 4

using System;
namespace Lab1
{
    class Customer
    {

       public int id;
        public string name;
        public double unit;
        public double charge;

        //public Customer(int id,string name, int unit, double charge)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.unit = unit;
        //    this.charge = charge;
        //}

        public void calculateBill()
        {
            if (unit <= 199)
            {
                charge = unit*1.20;
            }
            else if (unit >= 200 && unit < 400) 
            {
                charge = unit * 1.50;
            }
            else if (unit >= 400 && unit < 600)
            {
                charge = unit * 1.80;
                if (unit>400)
                {
                    charge = charge + (15 / 100);
                }
            }
            else if(unit >= 600)
            {
                charge = unit * 2.00;
                charge = charge + (15 / 100);
            }
        }

        public void printBill()
        {
            Console.Write("Your total bill is: ");
            Console.Write(charge);
        }
    }

    class program
    {
        static void Main(String[] args)
        {
            int ID;string Name=null; double Unit, Charge;
            Console.Write("Enter Customer id:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Units:");
            Unit = Convert.ToInt32(Console.ReadLine());
            Customer c = new Customer { id = ID, name = Name, unit = Unit, charge = 0 };
            c.calculateBill();
            c.printBill();
        }
    }
}


---------------------------------------------------------------------------------------------

//TASK 5

using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            FileStream f = new FileStream("Task5.txt", FileMode.Create);
            for(int i=0;i<5;i++)
            {
                f.WriteByte((byte)c);
                c++;
            }
            f.Close();
            FileStream f1 = new FileStream("Task5.txt", FileMode.Open);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((char)f1.ReadByte());
            }
            f1.Close();
        }
    }
}









