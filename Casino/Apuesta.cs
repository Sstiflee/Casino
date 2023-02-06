using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Bet//bet class, here you control the amount bet and the type of bet
    {
        private float amount;
        private String betType;

        public Bet()
        {
        }

        public Bet(float amount, String betType)
        {
            setAmount(amount);
            this.betType = betType;
        }

        public float getAmount()
        {
            return amount;
        }
        // if the amount is greater than 0 it will be saved
        public void setAmount(float amount)
        {
            if (amount > 0)
            {
                this.amount = amount;
            }
        }

        public String getBetType()
        {
            return betType;
        }

        public void setBetType(String betType)
        {
            this.betType = betType;
        }
        // to check the prize according to what type of bet
        public float checkBet(Cell myCell)
        {
            float reward = 0;

            switch (betType)
            {
                case "RED":
                case "BLACK": reward = checkColor(myCell);
                    break;
                case "EVEN":
                case "ODD": reward = checkParity(myCell);
                    break;
                case "MISS":
                case "PASS": reward = checkZone(myCell);
                    break;
                default: reward = checkNumber(myCell);
                    break;
            }
            return reward;
        }
        //prize for choosing a single number
        private float checkNumber(Cell myCell)
        {
            if (betType.Equals("" + myCell.getNumber()))
            {
                return amount * 36;
            }
            return 0;
        }
        //prize by zone (miss or pass)
        private float checkZone(Cell myCell)
        {
            if (betType.Equals(myCell.GetZone()))
            {
                return amount * 2;
            }
            return 0;
        }
        //prize for parity (odd or even)
        private float checkParity(Cell myCell)
        {
            if (betType.Equals(myCell.getParity()))
            {
                return amount * 2;
            }
            return 0;
        }
        //prize by color (red or black)
        private float checkColor(Cell myCell)
        {
            if (betType.Equals(myCell.getColor()))
            {
                return amount * 2;
            }
            return 0;
        }
    }
}
