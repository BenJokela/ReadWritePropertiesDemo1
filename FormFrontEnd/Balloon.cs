using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    public class Balloon
    {
        private double height;
        private double diameter;
        private string colour;

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                if(value.ToUpper() == "RED"|| value.ToUpper() == "BLUE")
                {
                    colour = value;

                }
                else
                {
                    throw new DataException("Colour must be blue or red");
                }
            }
        }


    }
}
