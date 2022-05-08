using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Espinosa
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
            
        }

        public static string name;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void width_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(width.Text, out int value))
            {
                width.BackColor = Color.White;
                if (value < 24 || value > 96)
                {
                    width.BackColor = Color.OrangeRed;
                    width.Focus();
                    MessageBox.Show("Minimum 24 inches and maximum 96 inches");
                }
            }
            else
            {
                width.Text = String.Empty;
                width.BackColor = Color.OrangeRed;
                width.Focus();
                MessageBox.Show("Enter a numeric value");
            }
        }

        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(depth.Text, 20))
            {
                depth.BackColor = Color.White;
            }
            else
            {
                depth.Text = String.Empty;
                depth.BackColor = Color.OrangeRed;
                depth.Focus();
                MessageBox.Show("Enter a numeric value");
            }
        }
    }
}
