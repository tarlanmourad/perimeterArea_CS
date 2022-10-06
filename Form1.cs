using System.Net.Http.Headers;

namespace perimeter
{
    public partial class pyramidCalculator : Form
    {

        const double pi = 3.14;

        public pyramidCalculator()
        {
            InitializeComponent();
        }

        private void pyramidCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtPrm.Text = "";
            txtHeight.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
        }

        private void btnCalcCone_Click(object sender, EventArgs e)
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

        private void btnClearCone_Click(object sender, EventArgs e)
        {
            txtAreaCone.Text = "";
            txtVolCone.Text = "";
            txtHghtCone.Text = "";
            txtRadCone.Text = "";
        }

        private void btnCalcCyl_Click(object sender, EventArgs e)
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

        private void btnClearCyl_Click(object sender, EventArgs e)
        {
            txtAreaCyl.Text = "";
            txtVolCyl.Text = "";
            txtHghtCyl.Text = "";
            txtRadCyl.Text = "";
        }
    }
}