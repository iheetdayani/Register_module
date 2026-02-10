namespace Project_8
{
    partial class signup
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
            LBLNAME = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            chktransectionreport = new CheckBox();
            chkreport = new CheckBox();
            chksms = new CheckBox();
            BTNSIGNUP = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LBLNAME
            // 
            LBLNAME.AutoSize = true;
            LBLNAME.BackColor = Color.AliceBlue;
            LBLNAME.Location = new Point(109, 42);
            LBLNAME.Name = "LBLNAME";
            LBLNAME.Size = new Size(94, 20);
            LBLNAME.TabIndex = 0;
            LBLNAME.Text = "FIRST NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(109, 100);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "LAST NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Location = new Point(88, 152);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "EMAIL-ADDRESS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chktransectionreport);
            groupBox1.Controls.Add(chkreport);
            groupBox1.Controls.Add(chksms);
            groupBox1.Location = new Point(88, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 160);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 83);
            label6.MinimumSize = new Size(400, 0);
            label6.Name = "label6";
            label6.Size = new Size(400, 20);
            label6.TabIndex = 5;
            label6.Text = "..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 28);
            label4.MaximumSize = new Size(100, 0);
            label4.MinimumSize = new Size(400, 0);
            label4.Name = "label4";
            label4.Size = new Size(400, 20);
            label4.TabIndex = 3;
            label4.Text = "..";
            // 
            // chktransectionreport
            // 
            chktransectionreport.AutoSize = true;
            chktransectionreport.Location = new Point(16, 83);
            chktransectionreport.Name = "chktransectionreport";
            chktransectionreport.Size = new Size(184, 24);
            chktransectionreport.TabIndex = 2;
            chktransectionreport.Text = "TRANSECTION REPORT";
            chktransectionreport.UseVisualStyleBackColor = true;
            chktransectionreport.CheckedChanged += chktransectionreport_CheckedChanged;
            // 
            // chkreport
            // 
            chkreport.AutoSize = true;
            chkreport.Location = new Point(16, 54);
            chkreport.Name = "chkreport";
            chkreport.Size = new Size(83, 24);
            chkreport.TabIndex = 1;
            chkreport.Text = "REPORT";
            chkreport.UseVisualStyleBackColor = true;
            chkreport.CheckedChanged += chkreport_CheckedChanged;
            // 
            // chksms
            // 
            chksms.AutoSize = true;
            chksms.Location = new Point(16, 24);
            chksms.Name = "chksms";
            chksms.Size = new Size(60, 24);
            chksms.TabIndex = 0;
            chksms.Text = "SMS";
            chksms.UseVisualStyleBackColor = true;
            chksms.CheckedChanged += chksms_CheckedChanged;
            // 
            // BTNSIGNUP
            // 
            BTNSIGNUP.Location = new Point(315, 389);
            BTNSIGNUP.Name = "BTNSIGNUP";
            BTNSIGNUP.Size = new Size(94, 29);
            BTNSIGNUP.TabIndex = 7;
            BTNSIGNUP.Text = "SIGNUP";
            BTNSIGNUP.UseVisualStyleBackColor = true;
            BTNSIGNUP.Click += BTNSIGNUP_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNSIGNUP);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LBLNAME);
            Name = "signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLNAME;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Label label6;
        private Label label4;
        private CheckBox chktransectionreport;
        private CheckBox chkreport;
        private CheckBox chksms;
        private Button BTNSIGNUP;
    }
}
