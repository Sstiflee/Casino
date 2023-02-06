using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public class Cell
    {
        private int number;
        private String color;
        private String parity;
        private String zone;

        public Cell()//cell class to get the values ​​of each cell
        {
        }

        public Cell(int number, String color, String parity, String zone)
        {
            this.number = number;
            this.color = color;
            this.parity = parity;
            this.zone = zone;
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public String getParity()
        {
            return parity;
        }

        public void SetParity(String parity)
        {
            this.parity = parity;
        }

        public String GetZone()
        {
            return zone;
        }

        public void setZone(String zone)
        {
            this.zone = zone;
        }
        // shows the result of the cell obtained
        public void print()
        {
            MessageBox.Show("Number: " + number);
            MessageBox.Show("Color: " + color);
            MessageBox.Show("Parity: " + parity);
            MessageBox.Show("Zone:" + zone);
        }
    }
}
