using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Espinosa
{
    public class DeskQuote
    {
        //This class will define the attributes of a quote including Desk, rush days, customer name, and quote date. 
        public Desk Desk;
        public string CustomerName;
        public string QuoteDate;
        public int RushDays;

        public DeskQuote (Desk desk, string customer_name, string quote_date, int rush_days)
        {
            this.Desk = desk;
            this.RushDays = rush_days;
            this.CustomerName = customer_name;
            this.QuoteDate = quote_date;
        }

        public DeskQuote (Desk desk, string customer_name, string quote_date) :
                       this(desk, customer_name, quote_date, 14)
        {
        }

        public DeskQuote()
        {

        }

        public int surfaceMaterialPrice(string surface_material)
        {
            if(surface_material == "Oak")
            {
                return 200;
            }else if (surface_material == "Laminate")
            {
                return 100;
            } else if (surface_material == "Pine")
            {
                return 50;
            }else if (surface_material == "Rosewood")
            {
                return 300;
            }else 
            {
                return 125;
            }
        }
        public int drawersPrice(int drawers)
        {
            return drawers * 50;
        }

        public int rushDaysPrice(int days, int width, int depth)
        {
            int area = width * depth;
            if(days == 3 && area < 1000)
            {
                return 60;
            }
            else if (days == 3 && (area >= 1000 && area <= 2000)){
                return 70;
            }
            else if (days ==3 && area > 2000)
            {
                return 80;
            }
            else if (days == 5 && area < 1000)
            {
                return 40;
            }
            else if (days == 5 && (area >= 1000 && area <= 2000))
            {
                return 50;
            }
            else if (days == 5 && area > 2000)
            {
                return 60;
            }
            else if (days == 7 && area < 1000)
            {
                return 30;
            }
            else if (days == 7 && (area >= 1000 && area <= 2000))
            {
                return 35;
            }
            else if (days == 7 && area > 2000)
            {
                return 40;
            }else
            {
                return 0;
            }
        }

        public int surfaceAreaPrice(int width, int depth)
        {
            int area = width* depth;
            if (area > 1000)
            {
                return area - 1000;
            }
            else
            {
                return 0;
            }
        }
    }
}
