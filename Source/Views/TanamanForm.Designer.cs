namespace PBO.Source.Views
{
    partial class TanamanForm
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.LocalImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pupuk = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Air = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.UrlImage = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pupuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(210, 209);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // LocalImage
            // 
            this.LocalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalImage.Location = new System.Drawing.Point(372, 160);
            this.LocalImage.Name = "LocalImage";
            this.LocalImage.Size = new System.Drawing.Size(278, 28);
            this.LocalImage.TabIndex = 4;
            this.LocalImage.TextChanged += new System.EventHandler(this.Image_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(236, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(236, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL Image";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(236, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // Nama
            // 
            this.Nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nama.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(312, 10);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(376, 28);
            this.Nama.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pupuk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Air);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Location = new System.Drawing.Point(240, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kebutuhan Tumbuhan";
            // 
            // Pupuk
            // 
            this.Pupuk.Location = new System.Drawing.Point(72, 63);
            this.Pupuk.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Pupuk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pupuk.Name = "Pupuk";
            this.Pupuk.Size = new System.Drawing.Size(57, 26);
            this.Pupuk.TabIndex = 3;
            this.Pupuk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pupuk";
            // 
            // Air
            // 
            this.Air.Location = new System.Drawing.Point(72, 27);
            this.Air.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Air.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(57, 26);
            this.Air.TabIndex = 2;
            this.Air.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Air";
            // 
            // UrlImage
            // 
            this.UrlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlImage.Location = new System.Drawing.Point(372, 194);
            this.UrlImage.Name = "UrlImage";
            this.UrlImage.Size = new System.Drawing.Size(316, 28);
            this.UrlImage.TabIndex = 5;
            this.UrlImage.TextChanged += new System.EventHandler(this.Image_TextChanged);
            // 
            // Tambah
            // 
            this.Tambah.BackColor = System.Drawing.Color.LemonChiffon;
            this.Tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tambah.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tambah.ForeColor = System.Drawing.Color.Green;
            this.Tambah.Location = new System.Drawing.Point(12, 241);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(676, 54);
            this.Tambah.TabIndex = 6;
            this.Tambah.Text = "Tambah Tumbuhan";
            this.Tambah.UseVisualStyleBackColor = false;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Location = new System.Drawing.Point(656, 160);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(32, 28);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(12, 9);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(210, 216);
            this.ErrorMessage.TabIndex = 9;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TanamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(699, 307);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.UrlImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalImage);
            this.Controls.Add(this.Picture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanamanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🌱 Tambah Tanaman Baru";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pupuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox LocalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Pupuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Air;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrlImage;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label ErrorMessage;
    }
}