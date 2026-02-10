namespace Project_8
{
    partial class confirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblfname = new Label();
            lbllname = new Label();
            lblemailaddress = new Label();
            lblservices = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(211, 97);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "first name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowText;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(211, 147);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(214, 198);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 2;
            label3.Text = "emailaddress:";
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.BackColor = SystemColors.WindowText;
            lblfname.Font = new Font("Segoe UI", 12F);
            lblfname.ForeColor = SystemColors.ControlLightLight;
            lblfname.Location = new Point(379, 97);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(65, 28);
            lblfname.TabIndex = 3;
            lblfname.Text = "label4";
            lblfname.Click += label4_Click;
            // 
            // lbllname
            // 
            lbllname.AutoSize = true;
            lbllname.BackColor = SystemColors.WindowText;
            lbllname.Font = new Font("Segoe UI", 12F);
            lbllname.ForeColor = SystemColors.ControlLightLight;
            lbllname.Location = new Point(379, 147);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(65, 28);
            lbllname.TabIndex = 4;
            lbllname.Text = "label5";
            // 
            // lblemailaddress
            // 
            lblemailaddress.AutoSize = true;
            lblemailaddress.BackColor = SystemColors.WindowText;
            lblemailaddress.Font = new Font("Segoe UI", 12F);
            lblemailaddress.ForeColor = SystemColors.ControlLightLight;
            lblemailaddress.Location = new Point(379, 198);
            lblemailaddress.Name = "lblemailaddress";
            lblemailaddress.Size = new Size(65, 28);
            lblemailaddress.TabIndex = 5;
            lblemailaddress.Text = "label6";
            // 
            // lblservices
            // 
            lblservices.AutoSize = true;
            lblservices.BackColor = SystemColors.WindowText;
            lblservices.Font = new Font("Segoe UI", 12F);
            lblservices.ForeColor = SystemColors.ControlLightLight;
            lblservices.Location = new Point(211, 274);
            lblservices.MaximumSize = new Size(400, 0);
            lblservices.MinimumSize = new Size(400, 0);
            lblservices.Name = "lblservices";
            lblservices.Size = new Size(400, 28);
            lblservices.TabIndex = 6;
            lblservices.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(196, 45);
            label4.MaximumSize = new Size(400, 0);
            label4.MinimumSize = new Size(400, 0);
            label4.Name = "label4";
            label4.Size = new Size(400, 20);
            label4.TabIndex = 7;
            label4.Text = "Thank you for register!!!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblservices);
            Controls.Add(lblemailaddress);
            Controls.Add(lbllname);
            Controls.Add(lblfname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Coral;
            Name = "confirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "confirmation";
            Load += confirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblfname;
        private Label lbllname;
        private Label lblemailaddress;
        private Label lblservices;
        private Label label4;
    }
}