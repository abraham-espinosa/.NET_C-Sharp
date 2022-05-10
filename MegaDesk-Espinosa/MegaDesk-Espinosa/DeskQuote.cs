using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Espinosa
{
    public class DeskQuote
    {
        //public member data
        public Desk Desk;
        public string CustomerName;
        public string QuoteDate;
        public int RushDays;

        //constructor

        public DeskQuote()
        {

        }
        public int sizeArea(int width, int depth)
        {
            return width * depth;
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
            return 50 * drawers;
        }

        public int rushDaysPrice(int days, int area)
        {
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

        public int surfaceAreaPrice(int area)
        {
            if (area > 1000)
            {
                return area - 1000;
            }
            else
            {
                return 0;
            }
        }

        public int totalCost(int surfaceAreaPrice, int rushDaysPrice, int surfaceMaterialPrice, int drawerPrice)
        {
            return surfaceAreaPrice + rushDaysPrice + surfaceMaterialPrice + drawerPrice + 200;
        }
    }
}
