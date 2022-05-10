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
        private int totalSize;
        public DisplayQuote(DeskQuote deskQuote)
        {
            _deskQuote = deskQuote;
            InitializeComponent();
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            basePriceLabel.Text = "$200";
            baseSizeIncludedLabel.Text = "1000";
            costInLabel.Text = "$1.00";

            totalSize = _deskQuote.sizeArea(_deskQuote.Desk.Width, _deskQuote.Desk.Depth);
            totalSizeLabel.Text = $"{totalSize}";

            sizeOverageLabel.Text = $"{_deskQuote.surfaceAreaPrice(totalSize)}";
            sizeCostLabel.Text = $"${_deskQuote.surfaceAreaPrice(totalSize)}";

            priceDrawerLabel.Text = "$50.00";
            drawerCostLabel.Text = $"${_deskQuote.drawersPrice(_deskQuote.Desk.Drawer)}";

            materialLabel.Text = $"{_deskQuote.Desk.SurfaceMaterial}";
            materialCostLabel.Text = $"${_deskQuote.surfaceMaterialPrice(_deskQuote.Desk.SurfaceMaterial)}";

            shippingMethodLabel.Text = $"{_deskQuote.RushDays}";
            shippingCostLabel.Text = $"${_deskQuote.rushDaysPrice(_deskQuote.RushDays, totalSize)}";

            totalCostLabel.Text = $"${_deskQuote.totalCost(_deskQuote.surfaceAreaPrice(totalSize), _deskQuote.rushDaysPrice(_deskQuote.RushDays, totalSize), _deskQuote.surfaceMaterialPrice(_deskQuote.Desk.SurfaceMaterial), _deskQuote.drawersPrice(_deskQuote.Desk.Drawer))}";
            //MessageBox.Show(_deskQuote.CustomerName);

            dateQuoteLabel.Text = $"{_deskQuote.QuoteDate}";
            customerLabel.Text = $"{_deskQuote.CustomerName}";
        }

        private void costInLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
