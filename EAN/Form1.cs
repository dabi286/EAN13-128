namespace EAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                lblMsg.Visible = false;

                // Encode barcode using Code128 class
                string encoded = Code128Class.EncodeB(richTextBox1.Text);

                // Assign barcode bars to barcode labels
                lblRes1.Text = encoded;
                lblRes2.Text = encoded;
                lblRes3.Text = encoded;
                lblRes4.Text = encoded;
                lblRes5.Text = encoded;

                // Assign human-readable digits (normal font)
                lblNumber1.Text = richTextBox1.Text;
                lblNumber2.Text = richTextBox1.Text;
                lblNumber3.Text = richTextBox1.Text;
                lblNumber4.Text = richTextBox1.Text;
                lblNumber5.Text = richTextBox1.Text;
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.ForeColor = System.Drawing.Color.Orange;
                lblMsg.Text = "ENTER STUDENT ID TO GENERATE BARCODE";
            }
        }
    }
}
