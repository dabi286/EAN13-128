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
            panel1 = new Panel();
            lblNumber5 = new Label();
            lblNumber4 = new Label();
            lblNumber3 = new Label();
            lblNumber2 = new Label();
            lblNumber1 = new Label();
            lblMsg = new Label();
            label12 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            lblRes5 = new Label();
            lblRes4 = new Label();
            lblRes3 = new Label();
            lblRes2 = new Label();
            lblRes1 = new Label();
            panel2 = new Panel();
            lblMsg2 = new Label();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNumber5);
            panel1.Controls.Add(lblNumber4);
            panel1.Controls.Add(lblNumber3);
            panel1.Controls.Add(lblNumber2);
            panel1.Controls.Add(lblNumber1);
            panel1.Controls.Add(lblMsg);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblRes5);
            panel1.Controls.Add(lblRes4);
            panel1.Controls.Add(lblRes3);
            panel1.Controls.Add(lblRes2);
            panel1.Controls.Add(lblRes1);
            panel1.Location = new Point(116, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 774);
            panel1.TabIndex = 1;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(184, 726);
            button1.Name = "button1";
            button1.Size = new Size(222, 47);
            button1.TabIndex = 3;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMsg2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(756, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 774);
            panel2.TabIndex = 2;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Location = new Point(219, 106);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(44, 15);
            lblMsg2.TabIndex = 16;
            lblMsg2.Text = "label13";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 66);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 13;
            label6.Text = "Enter 12 digits";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Century Gothic", 14.25F);
            richTextBox2.Location = new Point(156, 48);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(258, 45);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label11.Location = new Point(124, 614);
            label11.Name = "label11";
            label11.Size = new Size(320, 79);
            label11.TabIndex = 5;
            label11.Text = "7793253002183";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label10.Location = new Point(124, 492);
            label10.Name = "label10";
            label10.Size = new Size(320, 79);
            label10.TabIndex = 10;
            label10.Text = "7793253002183";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label9.Location = new Point(124, 379);
            label9.Name = "label9";
            label9.Size = new Size(320, 79);
            label9.TabIndex = 9;
            label9.Text = "7793253002183";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label8.Location = new Point(124, 252);
            label8.Name = "label8";
            label8.Size = new Size(320, 79);
            label8.TabIndex = 8;
            label8.Text = "7793253002183";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Code EAN13", 48F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label7.Location = new Point(124, 134);
            label7.Name = "label7";
            label7.Size = new Size(320, 79);
            label7.TabIndex = 7;
            label7.Text = "7793253002183";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(156, 726);
            button3.Name = "button3";
            button3.Size = new Size(222, 47);
            button3.TabIndex = 5;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 857);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnBack;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label lblRes5;
        private Label lblRes4;
        private Label lblRes3;
        private Label lblRes2;
        private Label lblRes1;
        private Button button3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
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
    }
}
