using System.Net.Http.Headers;

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

        private void btnPyramid_Click(object sender, EventArgs e)
        {
            frmPyramid form2 = new frmPyramid();
            form2.Show();
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            frmCone form3 = new frmCone();
            form3.Show();
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            frmCylinder form4 = new frmCylinder();
            form4.Show();
        }
    }
}