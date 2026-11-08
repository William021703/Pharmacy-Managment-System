namespace Pharmacy
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserLogin = new TextBox();
            PinLogin = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 41);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 125);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 1;
            label2.Text = "User :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 176);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 2;
            label3.Text = "Pin/Password :";
            // 
            // UserLogin
            // 
            UserLogin.Location = new Point(323, 128);
            UserLogin.Name = "UserLogin";
            UserLogin.Size = new Size(150, 31);
            UserLogin.TabIndex = 3;
            // 
            // PinLogin
            // 
            PinLogin.Location = new Point(323, 179);
            PinLogin.Name = "PinLogin";
            PinLogin.Size = new Size(150, 31);
            PinLogin.TabIndex = 4;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.ControlText;
            BtnLogin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.ButtonHighlight;
            BtnLogin.Location = new Point(166, 243);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(340, 34);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogin);
            Controls.Add(PinLogin);
            Controls.Add(UserLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserLogin;
        private TextBox PinLogin;
        private Button BtnLogin;
    }
}
