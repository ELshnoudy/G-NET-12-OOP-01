using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Timers;

namespace OOP_1
{
    public class Ticket
    {
        public string movieName;
        public typeOFTicket type;
        public seatLocation seat;
        private double price;

        public Ticket(string movieName, typeOFTicket type, seatLocation seat, double price)
        {
            this.movieName = movieName;
            this.type = type;
            this.seat = seat;
            this.price = price;
        }

        public Ticket(string moviname)
        {
            this.movieName = moviname;
            this.type = typeOFTicket.Standard;
            this.seat = new seatLocation('A', 1);
            this.price = 50;
        }

        public double CalcTotal(double taxPercent)
        {
            double TaxPercent = price * taxPercent / 100;
            return price + TaxPercent;
        }

        public void ApplayDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= price)
            {
                price -= discountAmount;
                discountAmount = 0;

            }
            else
                return;
        }

        public void printTicket()
        {
            Console.WriteLine($"Movie Name: {movieName}");
            Console.WriteLine($"Ticket Type: {type}");
            Console.WriteLine($"Seat Location: Row {seat.row}, Seat {seat.seatnumber}");
            Console.WriteLine($"Price: {price}");
        }

    }
}
