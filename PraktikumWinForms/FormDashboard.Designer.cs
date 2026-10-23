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
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
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
            DgUser.Location = new Point(119, 162);
            DgUser.Name = "DgUser";
            DgUser.Size = new Size(557, 181);
            DgUser.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.SeaGreen;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(291, 358);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 35);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(424, 358);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Crimson;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(557, 358);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(120, 35);
            btnHapus.TabIndex = 0;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
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
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Name = "FormDashboard";
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgUser;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
    }
}
