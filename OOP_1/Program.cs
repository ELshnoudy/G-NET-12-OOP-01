using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1
{
    public enum typeOFTicket
    {
        Standard=1,
        VIP,
        IMAX
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            //Explain with code example how class and struct behave differently
            // class is reference type and stord in heap but the struct is value type and stord in stack
            // class : create instance with new and it will stored in heap
            //class Student
            //{
            //    public string Name;
            //    public int Age;

            //    public void Introduce()
            //    {
            //        Console.WriteLine($"Hi, I'm {Name}, age {Age}");
            //    }
            //}
            // struct : create instance without new and it will stored in stack
            //struct Point
            //{
            //    public int X;
            //    public int Y;
            //}
            #endregion

            #region Q2
            //Explain the difference between public and private access modifiers with an example.
            // private  : The member is only accessible within the class or struct it is defined in
            // It cannot be accessed from outside the class
            //private enum OrderStatus { Pending, Processing, Shipped, Delivered }
            // this enum can only be accessed within the class or struct it is defined in and cannot be accessed from outside the class
            // public : The member is accessible from anywhere in the application,
            // both within the same assembly (project) and from other assemblies.
            //public enum OrderStatus { Pending, Processing, Shipped, Delivered }
            // this enum can accessed from anywhere in the app 
            #endregion

            #region Q4
            //What is a class library? Why do we use class libraries?
            //s a separate project that contains reusable classes, but has no Main method and cannot run on its own. It compiles into a .dll file
            //Reusability — write once, use in many projects
            //Organization — Separate concerns into different assemblies
            //Teamwork — different developers work on different libraries
            //Maintenance — fix a bug once, all projects benefit

            #endregion

            #endregion

            #region Part 02

            Console.Write("please enter the Movie Name");
            string movieName = Console.ReadLine()!;
            Console.Write("please Enter Ticket Type (1 = standard, 2 = vip, 3 = imax): ");
            int ticketTypeInput;
            int.TryParse(Console.ReadLine()!, out ticketTypeInput);
            typeOFTicket ticketType = (typeOFTicket)ticketTypeInput;
            Console.Write("please enter the seat row: ");
            char seatRow = Console.ReadLine()![0];
            Console.Write("please enter the seat number: ");
            int seatNumber;
            int.TryParse(Console.ReadLine()!, out seatNumber);
            seatLocation seat = new seatLocation(seatRow, seatNumber);
            Console.Write("please enter the ticket price: ");
            double ticketPrice;
            double.TryParse(Console.ReadLine()!, out ticketPrice);
            Console.Write("please enter the discount amount: ");
            double discountAmount;
            double.TryParse(Console.ReadLine()!, out discountAmount);
            Console.WriteLine("ticket info");
            Ticket ticket = new Ticket(movieName, ticketType, seat, ticketPrice);
            ticket.printTicket();
            Console.WriteLine( $"Total (14% tax): { ticket.CalcTotal(14)}");
            Console.WriteLine($"befor discount {discountAmount}");
            ticket.ApplayDiscount(ref discountAmount);
            Console.WriteLine($"after discount {discountAmount}");
            ticket.printTicket();














            #endregion
        }
    }
}
