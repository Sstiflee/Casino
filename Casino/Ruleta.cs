using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Roulette// roulette class
    {
        private Cell[] miCell;

        public Roulette()
        {
            //We make an array of 37 cells and each hole we give a numerical value of the roulette
            int[] positionNumber = { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };
            miCell = new Cell[37];
            //each square of the array obtains a position (number), color (red or black), parity (odd or even) and zone (miss or pass).
            for (int i = 0; i < miCell.Length; i++)
            {
                miCell[i] = new Cell(positionNumber[i], putColor(i), putParity(positionNumber[i]), putZone(positionNumber[i]));
            }


        }
        // missing from 1 to 18 and pass from 19 to 36
        private String putZone(int i)
        {
            if (i == 0)
            {
                return "0";
            }
            if (i >= 1 && i <= 18)
            {
                return "MISS";
            }
            return "PASS";
        }
        //if module is 0 it puts even, if it is 1 it puts odd
        private String putParity(int i)
        {
            if (i == 0)
            {
                return "0";
            }
            if (i % 2 == 0)
            {
                return "odd";
            }
            return "EVEN";
        }
        //if module is 0 it puts black, if it is 1  puts red
        private String putColor(int i)
        {
            if (i == 0)
            {
                return "Green";
            }
            if (i % 2 == 0)
            {
                return "BLACK";
            }
            return "RED";
        }
        // to throw the ball choose a number from 0 to 26 and return the given value
        public Cell throwBall()
        {
            int place;
            Random random = new Random();
            place = random.Next(0,miCell.Length);

            return miCell[place];
        }
    }
}
