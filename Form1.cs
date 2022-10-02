namespace perimeter
{
    public partial class pyramidCalculator : Form
    {
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
    }
}