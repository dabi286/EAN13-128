namespace EAN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBack = new PictureBox();
            panelEAN128 = new Panel();
            lblNumber5 = new Label();
            lblNumber4 = new Label();
            lblNumber3 = new Label();
            lblNumber2 = new Label();
            lblNumber1 = new Label();
            lblMsg = new Label();
            label12 = new Label();
            richTextBox1 = new RichTextBox();
            printEAN128 = new Button();
            lblRes5 = new Label();
            lblRes4 = new Label();
            lblRes3 = new Label();
            lblRes2 = new Label();
            lblRes1 = new Label();
            panelEAN13 = new Panel();
            txtBarcode = new TextBox();
            lblMsg2 = new Label();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            lbl2res5 = new Label();
            lbl2res4 = new Label();
            lbl2res3 = new Label();
            lbl2res2 = new Label();
            lbl2res = new Label();
            printEAN13 = new Button();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            panelEAN128.SuspendLayout();
            panelEAN13.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(1361, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(67, 34);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // panelEAN128
            // 
            panelEAN128.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelEAN128.BorderStyle = BorderStyle.FixedSingle;
            panelEAN128.Controls.Add(lblNumber5);
            panelEAN128.Controls.Add(lblNumber4);
            panelEAN128.Controls.Add(lblNumber3);
            panelEAN128.Controls.Add(lblNumber2);
            panelEAN128.Controls.Add(lblNumber1);
            panelEAN128.Controls.Add(lblMsg);
            panelEAN128.Controls.Add(label12);
            panelEAN128.Controls.Add(richTextBox1);
            panelEAN128.Controls.Add(printEAN128);
            panelEAN128.Controls.Add(lblRes5);
            panelEAN128.Controls.Add(lblRes4);
            panelEAN128.Controls.Add(lblRes3);
            panelEAN128.Controls.Add(lblRes2);
            panelEAN128.Controls.Add(lblRes1);
            panelEAN128.Location = new Point(116, 42);
            panelEAN128.Name = "panelEAN128";
            panelEAN128.Size = new Size(563, 774);
            panelEAN128.TabIndex = 1;
            // 
            // lblNumber5
            // 
            lblNumber5.AutoSize = true;
            lblNumber5.Location = new Point(245, 689);
            lblNumber5.Name = "lblNumber5";
            lblNumber5.Size = new Size(61, 15);
            lblNumber5.TabIndex = 20;
            lblNumber5.Text = "345345654";
            // 
            // lblNumber4
            // 
            lblNumber4.AutoSize = true;
            lblNumber4.Location = new Point(245, 569);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(61, 15);
            lblNumber4.TabIndex = 19;
            lblNumber4.Text = "345345654";
            // 
            // lblNumber3
            // 
            lblNumber3.AutoSize = true;
            lblNumber3.Location = new Point(245, 454);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(61, 15);
            lblNumber3.TabIndex = 18;
            lblNumber3.Text = "345345654";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(245, 325);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(61, 15);
            lblNumber2.TabIndex = 17;
            lblNumber2.Text = "345345654";
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(245, 210);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(61, 15);
            lblNumber1.TabIndex = 16;
            lblNumber1.Text = "345345654";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(227, 106);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(44, 15);
            lblMsg.TabIndex = 15;
            lblMsg.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(73, 56);
            label12.Name = "label12";
            label12.Size = new Size(90, 17);
            label12.TabIndex = 14;
            label12.Text = "Enter 12 digits";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(184, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 45);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // printEAN128
            // 
            printEAN128.BackColor = Color.FromArgb(0, 192, 0);
            printEAN128.FlatStyle = FlatStyle.Flat;
            printEAN128.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printEAN128.ForeColor = Color.White;
            printEAN128.Location = new Point(184, 726);
            printEAN128.Name = "printEAN128";
            printEAN128.Size = new Size(222, 47);
            printEAN128.TabIndex = 3;
            printEAN128.Text = "Print";
            printEAN128.UseVisualStyleBackColor = false;
            printEAN128.Click += printEAN128_Click;
            // 
            // lblRes5
            // 
            lblRes5.AutoSize = true;
            lblRes5.Font = new Font("Code 128", 48F);
            lblRes5.Location = new Point(184, 614);
            lblRes5.Name = "lblRes5";
            lblRes5.Size = new Size(248, 63);
            lblRes5.TabIndex = 4;
            lblRes5.Text = "7793253002183";
            // 
            // lblRes4
            // 
            lblRes4.AutoSize = true;
            lblRes4.Font = new Font("Code 128", 48F);
            lblRes4.Location = new Point(184, 492);
            lblRes4.Name = "lblRes4";
            lblRes4.Size = new Size(248, 63);
            lblRes4.TabIndex = 3;
            lblRes4.Text = "7793253002183";
            // 
            // lblRes3
            // 
            lblRes3.AutoSize = true;
            lblRes3.Font = new Font("Code 128", 48F);
            lblRes3.Location = new Point(184, 379);
            lblRes3.Name = "lblRes3";
            lblRes3.Size = new Size(248, 63);
            lblRes3.TabIndex = 2;
            lblRes3.Text = "7793253002183";
            // 
            // lblRes2
            // 
            lblRes2.AutoSize = true;
            lblRes2.Font = new Font("Code 128", 48F);
            lblRes2.Location = new Point(184, 252);
            lblRes2.Name = "lblRes2";
            lblRes2.Size = new Size(248, 63);
            lblRes2.TabIndex = 1;
            lblRes2.Text = "7793253002183";
            // 
            // lblRes1
            // 
            lblRes1.AutoSize = true;
            lblRes1.Font = new Font("Code 128", 48F);
            lblRes1.Location = new Point(184, 134);
            lblRes1.Name = "lblRes1";
            lblRes1.Size = new Size(248, 63);
            lblRes1.TabIndex = 0;
            lblRes1.Text = "7793253002183";
            // 
            // panelEAN13
            // 
            panelEAN13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelEAN13.BorderStyle = BorderStyle.FixedSingle;
            panelEAN13.Controls.Add(txtBarcode);
            panelEAN13.Controls.Add(lblMsg2);
            panelEAN13.Controls.Add(label6);
            panelEAN13.Controls.Add(richTextBox2);
            panelEAN13.Controls.Add(lbl2res5);
            panelEAN13.Controls.Add(lbl2res4);
            panelEAN13.Controls.Add(lbl2res3);
            panelEAN13.Controls.Add(lbl2res2);
            panelEAN13.Controls.Add(lbl2res);
            panelEAN13.Controls.Add(printEAN13);
            panelEAN13.Location = new Point(756, 42);
            panelEAN13.Name = "panelEAN13";
            panelEAN13.Size = new Size(560, 787);
            panelEAN13.TabIndex = 2;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(156, 19);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(258, 23);
            txtBarcode.TabIndex = 17;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyPress += textBox1_KeyPress;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Location = new Point(201, 48);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(44, 15);
            lblMsg2.TabIndex = 16;
            lblMsg2.Text = "label13";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 21);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 13;
            label6.Text = "Enter 12 digits";
            // 
            // richTextBox2
            // 
            richTextBox2.Enabled = false;
            richTextBox2.Font = new Font("Century Gothic", 14.25F);
            richTextBox2.Location = new Point(156, 76);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(258, 45);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // lbl2res5
            // 
            lbl2res5.AutoSize = true;
            lbl2res5.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbl2res5.Location = new Point(175, 614);
            lbl2res5.Name = "lbl2res5";
            lbl2res5.Size = new Size(320, 79);
            lbl2res5.TabIndex = 5;
            lbl2res5.Text = "7793253002183";
            // 
            // lbl2res4
            // 
            lbl2res4.AutoSize = true;
            lbl2res4.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbl2res4.Location = new Point(175, 492);
            lbl2res4.Name = "lbl2res4";
            lbl2res4.Size = new Size(320, 79);
            lbl2res4.TabIndex = 10;
            lbl2res4.Text = "7793253002183";
            // 
            // lbl2res3
            // 
            lbl2res3.AutoSize = true;
            lbl2res3.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbl2res3.Location = new Point(175, 379);
            lbl2res3.Name = "lbl2res3";
            lbl2res3.Size = new Size(320, 79);
            lbl2res3.TabIndex = 9;
            lbl2res3.Text = "7793253002183";
            // 
            // lbl2res2
            // 
            lbl2res2.AutoSize = true;
            lbl2res2.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbl2res2.Location = new Point(175, 252);
            lbl2res2.Name = "lbl2res2";
            lbl2res2.Size = new Size(320, 79);
            lbl2res2.TabIndex = 8;
            lbl2res2.Text = "7793253002183";
            // 
            // lbl2res
            // 
            lbl2res.AutoSize = true;
            lbl2res.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbl2res.Location = new Point(175, 134);
            lbl2res.Name = "lbl2res";
            lbl2res.Size = new Size(320, 79);
            lbl2res.TabIndex = 7;
            lbl2res.Text = "7793253002183";
            // 
            // printEAN13
            // 
            printEAN13.BackColor = Color.FromArgb(0, 192, 0);
            printEAN13.FlatStyle = FlatStyle.Flat;
            printEAN13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printEAN13.ForeColor = Color.White;
            printEAN13.Location = new Point(175, 726);
            printEAN13.Name = "printEAN13";
            printEAN13.Size = new Size(222, 47);
            printEAN13.TabIndex = 5;
            printEAN13.Text = "Print";
            printEAN13.UseVisualStyleBackColor = false;
            printEAN13.Click += printEAN13_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 857);
            Controls.Add(panelEAN13);
            Controls.Add(panelEAN128);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            panelEAN128.ResumeLayout(false);
            panelEAN128.PerformLayout();
            panelEAN13.ResumeLayout(false);
            panelEAN13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnBack;
        private Panel panelEAN128;
        private Panel panelEAN13;
        private Button printEAN128;
        private Label lblRes5;
        private Label lblRes4;
        private Label lblRes3;
        private Label lblRes2;
        private Label lblRes1;
        private Button printEAN13;
        private Label lbl2res5;
        private Label lbl2res4;
        private Label lbl2res3;
        private Label lbl2res2;
        private Label lbl2res;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label6;
        private Label label12;
        private Label lblMsg;
        private Label lblMsg2;
        private Label lblNumber5;
        private Label lblNumber4;
        private Label lblNumber3;
        private Label lblNumber2;
        private Label lblNumber1;
        private TextBox txtBarcode;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
