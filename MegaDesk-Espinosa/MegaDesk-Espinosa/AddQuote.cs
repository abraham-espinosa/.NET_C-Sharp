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
            //if(width.Text !=String.Empty && depth.Text != String.Empty && drawer.Text != String.Empty && surface_material.Text != String.Empty && rush_days.Text != String.Empty && customer_name.Text != String.Empty)
            //{
            try
            {
                _desk.Width = Convert.ToInt32(width.Text);
                _desk.Depth = Convert.ToInt32(depth.Text);
                _desk.Drawer = Convert.ToInt32(drawer.Text);
                _desk.SurfaceMaterial = Convert.ToString(surface_material.Text);

                _deskQuote.RushDays = Convert.ToInt32(rush_days.Text);
                _deskQuote.QuoteDate = date.ToString("MMMM dd yyyy");
                _deskQuote.CustomerName = Convert.ToString(customer_name.Text);
                _deskQuote.Desk = _desk;

                var displayQuote = new DisplayQuote(_deskQuote);
                this.Hide();
                displayQuote.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            //}
           // else
//{

           // }
        }

        private void width_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(width.Text, out int value))
            {
                width.BackColor = Color.White;
                SubmitOrderButton.Enabled = true;
                if (value < 24 || value > 96)
                {
                    SubmitOrderButton.Enabled = false;
                    width.BackColor = Color.OrangeRed;
                    width.Focus();
                    MessageBox.Show("Minimum 24 inches and maximum 96 inches");
                }
            }
            else
            {
                if (width.Text != String.Empty)
                {
                    SubmitOrderButton.Enabled = false;
                    width.Text = String.Empty;
                    width.BackColor = Color.OrangeRed;
                    width.Focus();
                    MessageBox.Show("Enter a numeric value");
                }
            }
        }

        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsDigit(e.KeyChar))
            {
                depth.BackColor = Color.White;
                if (int.TryParse(depth.Text, out int value))
                {
                    SubmitOrderButton.Enabled = true;
                    if (value < 12 || value > 48)
                    {
                        SubmitOrderButton.Enabled = false;
                        width.BackColor = Color.OrangeRed;
                        width.Focus();
                        MessageBox.Show("Minimum 12 inches and maximum of 48 inches");
                    }
                }
            }
            else
            {
                if (depth.Text != String.Empty) {
                SubmitOrderButton.Enabled = false;
                depth.BackColor = Color.OrangeRed;
                depth.Focus();
                MessageBox.Show("Enter a numeric value");
                depth.Text = String.Empty;
                }
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            surface_material.Items.Add("Oak");
            surface_material.Items.Add("Laminate");
            surface_material.Items.Add("Pine");
            surface_material.Items.Add("Rosewood");
            surface_material.Items.Add("Veneer");

            rush_days.Items.Add("3");
            rush_days.Items.Add("5");
            rush_days.Items.Add("7");
            rush_days.Items.Add("14");

        }
    }
}
