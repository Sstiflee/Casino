using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class Casino : Form
    {
        //we pass the classes to the general to use them at any time
        static Roulette rulette;
        static Player player;
        static Bet bet;
        String tipy;
        float  amount, reward;
        Cell cell;

        private void btnEven_Click(object sender, EventArgs e)//button even
        {
            
            tipy = "EVEN";
            changeBet(tipy);
            putButton(tipy);
        }
        private void changeBet(String a)//when changing the button returns the previous values
        {
            if(a != bet.getBetType())
            {
                player.setBalance(player.getBalance() + amount);
                amount = 0;
                updateBalance();
                lbAmount.Text = amount.ToString();

            }
        }
        

        private void putButton(String a)//when click a button :
        {
            btnExit.Enabled = false;//you can't get out of the game
            btnPlay.Enabled = true;// the run can be started
            bet.setBetType(tipy);//change the type of bet
            lbMyBet.Text = MyBet(tipy);//shows the current bet
            if (player.decreaseBalance())//if the balance can be reduced
            {
                amount++;// put 1 more to the amount bet
                updateBalance();//balance is updated
                lbAmount.Text = amount.ToString();//shows the amount bet
                bet = new Bet(amount, tipy);//create a new bet
            }
            else// if can´t be
            {
               MessageBox.Show("You don't have enough balance");//displays a message on the screen
            }
        }

        private void btnOdd_Click(object sender, EventArgs e)//button Odd
        {
            tipy = "ODD";
            changeBet(tipy);
            putButton(tipy);
        }

        public Casino()
        {

            bet = new Bet();
            rulette = new Roulette();
            InitializeComponent();
            reStartRoulette();
           
        }
        public Casino(Player j)
        {
            player = j;
            bet = new Bet();
            rulette = new Roulette();
            InitializeComponent();
            reStartRoulette();

        }

        private void Casino_Load(object sender, EventArgs e)
        {
            //iniciarJugador();
            lbName.Text = player.getName();
            lbBalance.Text = player.getBalance().ToString();

        }
        private void btn0_Click(object sender, EventArgs e)//button 0
        {
            tipy = "0";
            changeBet(tipy);
            putButton(tipy);
        }
        private void btnPlay_Click(object sender, EventArgs e)//button Play
        {
            cell = rulette.throwBall();//the result of the ball in the box is saved
            cell.print();//the result is displayed on the screen

            reward = bet.checkBet(cell);//check the prize with the box
            if (reward > 0)//if the prize result is greater than 0
            {
                player.increaseBalance(reward);//the amount to the player's balance is increased
                lbResultado.Text = ("!!!!you've won!!!!!");//the result is displayed on the screen
                updateBalance();//balance is updated
            }
            else//if not
            {
                lbResultado.Text = ("-----you have lost-----");//the result is displayed on the screen
            }
            if (player.getBalance() == 0)//if the player after playing continues with 0 balance
            {
                MessageBox.Show("Thank you for coming to the Adrián Belarte casino " + player.getName() + " You have no more balance to continue playing");//message
                Close();//close the game
            }
            reStartRoulette();//to restart the game again for a new bet
        }

        private void btnBlack_Click(object sender, EventArgs e)//button Black
        {
            tipy = "BLACK";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btnMiss_Click(object sender, EventArgs e)//boton Miss
        {
            tipy = "MISS";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btnPass_Click(object sender, EventArgs e)//boton pass
        {
            tipy = "PASS";
            changeBet(tipy);
            putButton(tipy);
        }
        //all the following buttons are numbers
        private void btn1_Click(object sender, EventArgs e)
        {
            tipy = "1";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tipy = "2";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tipy = "3";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tipy = "4";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tipy = "5";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tipy = "6";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tipy = "7";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tipy = "8";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tipy = "9";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            tipy = "10";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            tipy = "11";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            tipy = "12";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            tipy = "13";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            tipy = "14";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            tipy = "15";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            tipy = "16";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            tipy = "17";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            tipy = "18";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            tipy = "19";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            tipy = "20";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            tipy = "21";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            tipy = "22";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            tipy = "23";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            tipy = "24";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            tipy = "25";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            tipy = "26";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            tipy = "27";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            tipy = "28";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            tipy = "29";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            tipy = "30";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            tipy = "31";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            tipy = "32";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            tipy = "33";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            tipy = "34";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            tipy = "35";
            changeBet(tipy);
            putButton(tipy);
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            tipy = "36";
            changeBet(tipy);
            putButton(tipy);
        }
        
        private void btnExit_Click(object sender, EventArgs e)//button to exit the game
        {
            MessageBox.Show("Thank you for coming to the 'Adrian Belarte' casino"+ player.getName() + ", you go with: " + player.getBalance()+ "€");
            Close();
        }

        private String MyBet(String a)//to change the label of the text according to bet
        {
            String txt;

            switch (a)
            {
                case "RED":
                    txt = "Your bet is on 'RED'";
                    break;
                case "BLACK":
                    txt = "Your bet is on 'BLACK'";
                    break;
                case "EVEN":
                    txt = "Your bet is on'EVEN'";
                    break;
                case "ODD":
                    txt = "Your bet is on 'ODD'";
                    break;
                case "MISS":
                    txt = "Your bet is on 'MISS'";
                    break;
                case "PASS":
                    txt = "Your bet is on 'PASS'";
                    break;
                default:
                    txt = "Your bet is on number " + tipy;
                    break;
            }


            return txt;
        }

        //to update the balance label
        private void updateBalance()
        {
            lbBalance.Text = player.getBalance().ToString();
        }

        private void btnRed_Click(object sender, EventArgs e)//button RED
        {
            tipy = "ROJO";
            changeBet(tipy);
            putButton(tipy);
        }

        //to reset the values ​​at each move
        private void reStartRoulette()
        {
            tipy = "";
            lbAmount.Text = "";
            lbMyBet.Text = "";
            btnPlay.Enabled = false;
            btnExit.Enabled = true;
            amount = 0;
        }
        
    }
}
