namespace PraktikumWinForms
{
    partial class LoginForm
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
            panel1 = new Panel();
            BtnLogin = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(253, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 400);
            panel1.TabIndex = 0;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DeepSkyBlue;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(92, 308);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(98, 30);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = SystemColors.Window;
            TbPassword.BorderStyle = BorderStyle.None;
            TbPassword.Cursor = Cursors.IBeam;
            TbPassword.Location = new Point(22, 268);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(254, 16);
            TbPassword.TabIndex = 5;
            TbPassword.UseSystemPasswordChar = true;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = SystemColors.Window;
            TbUsername.BorderStyle = BorderStyle.None;
            TbUsername.Cursor = Cursors.IBeam;
            TbUsername.Location = new Point(22, 210);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(254, 16);
            TbUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 250);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 192);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 149);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Link_QR;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(81, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 116);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bdf1403ebbabe6a1f171ed67c5b91503;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button BtnLogin;
    }
}
