using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon myBalloon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                myBalloon = new Balloon()
                {
                    Colour = txtColor.Text,
                    Diameter = Convert.ToDouble(txtDiameter.Text),
                    Height = Convert.ToDouble(txtHeight.Text)

                };
                //myBalloon.Height = Convert.ToDouble(txtHeight.Text);
                //myBalloon.Diameter = Convert.ToDouble(txtDiameter.Text);
                //myBalloon.Colour = txtColor.Text;
            }
            catch (DataException da)
            {
                MessageBox.Show(da.Message, da.GetType().ToString(),MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"Colour: { myBalloon.Colour} \nHeight: {myBalloon.Height}\nDiameter: {myBalloon.Diameter}";
        }
    }
}
