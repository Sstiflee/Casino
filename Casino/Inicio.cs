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
    public partial class Inicio : Form
    {
        static Player player;
        String name;
        float balance;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnConfir_Click(object sender, EventArgs e)//to confirm player and balance
        {
            if(name != null && balance > 0)
            {
                player = new Player(balance, name);//create the player
                Casino casino = new Casino(player);//pass the player to the casino window
                casino.Show();//open the window casino
                this.Hide();//hide this window
            }
            else//if the 2 fields are not completed
            {
                MessageBox.Show("You are missing data to complete");
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            name = txtBoxNombre.Text;
        }

        private void nUpDBalance_ValueChanged(object sender, EventArgs e)
        {
            balance = (float)nUpBalance.Value;
        }
    }
}
