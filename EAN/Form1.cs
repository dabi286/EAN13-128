using System.Data;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

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

                string encoded = Code128Class.EncodeB(richTextBox1.Text);

                lblRes1.Text = encoded;
                lblRes2.Text = encoded;
                lblRes3.Text = encoded;
                lblRes4.Text = encoded;
                lblRes5.Text = encoded;

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
                lblMsg.Text = "ENTER VALUE TO GENERATE BARCODE";
            }
        }


        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            {

                string Barrcode, Check12Digits;

                if (txtBarcode.Text != "")
                {
                    lblMsg2.Visible = false;
                    Check12Digits = txtBarcode.Text.PadRight(12, '0');
                    Barrcode = EAN13Class.EAN13(Check12Digits);

                    lbl2res.Text = Barrcode;
                    lbl2res2.Text = Barrcode;
                    lbl2res3.Text = Barrcode;
                    lbl2res4.Text = Barrcode;
                    lbl2res5.Text = Barrcode;


                    if (!String.Equals(EAN13Class.Barcode13Digits, "") || (EAN13Class.Barcode13Digits != ""))
                    {
                        richTextBox2.Text = EAN13Class.Barcode13Digits.ToString();
                        Int32 intStart = Convert.ToInt32(richTextBox2.TextLength - 1);
                        CambioColorText.ChangeColor(richTextBox2, intStart);
                    }
                }
                else
                {
                    lblMsg2.Visible = true;
                    lblMsg2.ForeColor = System.Drawing.Color.Orange;
                    lblMsg2.Text = "ENTER VALUE";
                }
            }
        }


        public void Print(Panel panel1)
        {
            GetPrintArea(panel1);

            PaperSize paperSize = new PaperSize("My Envelope", 680, 860);
            paperSize.RawKind = (int)PaperKind.A4;

            printDocument1.DefaultPageSettings.PaperSize = paperSize;
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 100, 0);

            PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
            printDocument1.DocumentName = "Barcode_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            MyPrintPreviewDialog.WindowState = FormWindowState.Maximized;
            MyPrintPreviewDialog.PrintPreviewControl.Zoom = 1.0;
            MyPrintPreviewDialog.Document = printDocument1;
            MyPrintPreviewDialog.ShowDialog();
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panelEAN13.Width / 2), this.panelEAN13.Location.Y);
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel panel1)
        {
            MemoryImage = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(MemoryImage, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                bool ignoreKeyPress = false;

                bool matchString = Regex.IsMatch(txtBarcode.Text.ToString(), @"\.\d\d\d");

                if (e.KeyChar == '\b') // Always allow a Backspace
                    ignoreKeyPress = false;
                else if (matchString)
                    ignoreKeyPress = true;
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    ignoreKeyPress = true;
                else if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    ignoreKeyPress = true;

                e.Handled = ignoreKeyPress;

            }
            catch
            {
            }
        }

        private void printEAN128_Click(object sender, EventArgs e)
        {
            Print(this.panelEAN128);
        }

        private void printEAN13_Click(object sender, EventArgs e)
        {
            Print(this.panelEAN13);
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Cursor = Cursors.Hand;
        }

        private void printEAN13_MouseEnter(object sender, EventArgs e)
        {
            printEAN13.Cursor = Cursors.Hand;
        }

        private void printEAN128_MouseEnter(object sender, EventArgs e)
        {
            printEAN128.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            lblMsg2.Visible = false;
        }
    }
}
