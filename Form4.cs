using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimeter
{
    public partial class frmCylinder : Form
    {
        public frmCylinder()
        {
            InitializeComponent();
        }

        const double pi = 3.14;

        private void btnCalcCyl_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtHghtCyl.Text == "" || txtRadCyl.Text == "")
                {
                    MessageBox.Show("Maku sure you entered each parameter!", "Unassigned Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    double h = Convert.ToDouble(txtHghtCyl.Text);
                    double r = Convert.ToDouble(txtRadCyl.Text);

                    if (h <= 0 || r <= 0)
                    {
                        MessageBox.Show("Invalid value - Please enter valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        // VOLUME
                        double vol = pi * Math.Pow(r, 2) * h;
                        txtVolCyl.Text = vol.ToString();

                        // SURFACE AREA
                        double area = 2 * pi * r * (h + r);
                        txtAreaCyl.Text = area.ToString();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Exception case has occured!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClearCyl_Click(object sender, EventArgs e)
        {
            txtAreaCyl.Text = "";
            txtVolCyl.Text = "";
            txtHghtCyl.Text = "";
            txtRadCyl.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
