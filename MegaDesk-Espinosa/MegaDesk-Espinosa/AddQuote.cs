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
        // Display the current date using this format: 27 August 2020
        DateTime date = DateTime.Now;

        private readonly Desk _desk = new Desk();
        private readonly DeskQuote _deskQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
            dateLabel.Text = date.ToString("MMMM dd yyyy");            
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
            _desk.Width = Convert.ToInt32(width.Text);
            _desk.Depth = Convert.ToInt32(depth.Text);
            _desk.Drawer = Convert.ToInt32(depth.Text);
            _desk.SurfaceMaterial = Convert.ToString(surface_material.Text);

            _deskQuote.RushDays = Convert.ToInt32(rush_days.Text);
            _deskQuote.QuoteDate = date.ToString("MMMM dd yyyy");
            _deskQuote.CustomerName = Convert.ToString(customer_name.Text);
            _deskQuote.Desk = _desk;

            var displayQuote = new DisplayQuote(_deskQuote);
            this.Hide();
            displayQuote.ShowDialog();
            
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
            //if (Char.IsDigit(depth.Text, 20))
            //{
            //    depth.BackColor = Color.White;
            //}
            //else
            //{
            //    depth.Text = String.Empty;
            //    depth.BackColor = Color.OrangeRed;
            //    depth.Focus();
            //    MessageBox.Show("Enter a numeric value");
            //}
        }
    }
}
