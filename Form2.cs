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
    public partial class frmPyramid : Form
    {
        public frmPyramid()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHeight.Text == "" || txtWidth.Text == "" || txtLength.Text == "")
                {
                    MessageBox.Show("Maku sure you entered each parameter!", "Unassigned Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    double h = Convert.ToDouble(txtHeight.Text);
                    double w = Convert.ToDouble(txtWidth.Text);
                    double l = Convert.ToDouble(txtLength.Text);

                    if (h <= 0 || w <= 0 || l <= 0)
                    {
                        MessageBox.Show("Invalid value - Please enter valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        // SURFACE AREA
                        double area = l * w + l * Math.Sqrt(w * w / 4 + h * h) + w * Math.Sqrt(l * l / 4 + h * h);
                        txtArea.Text = area.ToString();

                        // BASE PERIMETER
                        double prm = l * w / 2;
                        txtPrm.Text = prm.ToString();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Exception case has occured!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtPrm.Text = "";
            txtHeight.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
