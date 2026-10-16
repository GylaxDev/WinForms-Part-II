namespace PraktikumWinForms
{
    partial class FormDashboard
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
            DgUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 45);
            label1.Name = "label1";
            label1.Size = new Size(273, 30);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang Pengguna";
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(109, 155);
            DgUser.Name = "DgUser";
            DgUser.Size = new Size(557, 181);
            DgUser.TabIndex = 1;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bdf1403ebbabe6a1f171ed67c5b91503;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DgUser);
            Controls.Add(label1);
            Name = "FormDashboard";
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgUser;
    }
}