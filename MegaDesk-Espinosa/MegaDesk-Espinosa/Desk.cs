using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Espinosa
{
    public class Desk
    {
        //private member data
        public int Width;
        public int Depth;
        public int Drawer;
        public string SurfaceMaterial;

        //constructor
        public Desk (int width, int depth, int drawer, string surface_material)
        {
            this.Width = width;
            this.Depth = depth;
            this.Drawer = drawer;
            this.SurfaceMaterial = surface_material;
        }

        public Desk()
        {

        }

    }
}
