using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public class Player //player class, here the name and balance of the player are stored
    {
        private float balance;
        private String name;

        public Player()
        {
        }

        public Player(float balance, String name)
        {
            setBalance(balance);
            this.name = name;
        }

        public float getBalance()
        {
            return balance;
        }

        public void setBalance(float balance)
        {
                this.balance = balance;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {

            this.name = name;

        }
        //to increase the current balance plus the amount obtained by playing
        public void increaseBalance(float amount)
        {
            balance += amount;
        }
        //to bet and only if the balance is greater than 0
        public bool decreaseBalance()
        {
            if (balance > 0)
            {
                balance--;
                return true;
            }
            return false;
        }
    }
}
