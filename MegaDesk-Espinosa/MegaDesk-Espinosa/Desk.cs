using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Espinosa
{
    public class Desk

    {
        //public member data
        public int Width;
        public int Depth;
        public int Drawer;
        public string SurfaceMaterial;
        //constant width and depth max and min 
        public const int WIDTH_MAX = 96;
        public const int WIDTH_MIN = 24;
        public const int DEPTH_MAX = 48;
        public const int DEPTH_MIN = 12;


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

    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
