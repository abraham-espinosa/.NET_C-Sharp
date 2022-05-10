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
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            _deskQuote = deskQuote;
            InitializeComponent();
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(_deskQuote.CustomerName));

        }
    }
}
