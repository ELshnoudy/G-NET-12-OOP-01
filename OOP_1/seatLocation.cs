using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1
{
    public struct seatLocation
    {
       public char row;
       public int seatnumber;

        public seatLocation(char row, int number)
        {
            row = row;
            seatnumber = number;
        }
    }
}
