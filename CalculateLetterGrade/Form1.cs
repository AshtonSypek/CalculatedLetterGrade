using static System.Formats.Asn1.AsnWriter;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtNumberGrade.Text);
            if (score >= 90)
                txtLetterGrade.Text = "A";
            else if (score >= 80)
                txtLetterGrade.Text = "B";
            else if (score >= 70)
                txtLetterGrade.Text = "C";
            else if (score >= 60)
                txtLetterGrade.Text = "D";
            else
                txtLetterGrade.Text = "F";
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculateGrade_Load(object sender, EventArgs e)
        {

        }

        private void txtLetterGrade_TextChanged(object sender, EventArgs e)
        {


        }
    }
}