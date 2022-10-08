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
    public partial class frmCone : Form
    {
        public frmCone()
        {
            InitializeComponent();
        }

        const double pi = 3.14;

        private void btnCalcCone_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHghtCone.Text == "" || txtRadCone.Text == "")
                {
                    MessageBox.Show("Maku sure you entered each parameter!", "Unassigned Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    double h = Convert.ToDouble(txtHghtCone.Text);
                    double r = Convert.ToDouble(txtRadCone.Text);

                    if (h <= 0 || r <= 0)
                    {
                        MessageBox.Show("Invalid value - Please enter valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        // VOLUME
                        double vol = pi * Math.Pow(r, 2) * h / 3;
                        txtVolCone.Text = vol.ToString();

                        // SURFACE AREA
                        double area = pi * r * (Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + r);
                        txtAreaCone.Text = area.ToString();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Exception case has occured!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClearCone_Click(object sender, EventArgs e)
        {
            txtAreaCone.Text = "";
            txtVolCone.Text = "";
            txtHghtCone.Text = "";
            txtRadCone.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
