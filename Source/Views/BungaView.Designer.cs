namespace PBO.Source.Views
{
    partial class BungaView
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture.Location = new System.Drawing.Point(164, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(400, 400);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Green;
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.Location = new System.Drawing.Point(12, 426);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(698, 57);
            this.title.TabIndex = 1;
            this.title.Text = "Selamat Kamu Mendapatkan";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.Color.Transparent;
            this.nama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nama.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.Color.Lime;
            this.nama.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nama.Location = new System.Drawing.Point(12, 487);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(698, 57);
            this.nama.TabIndex = 2;
            this.nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BungaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBO.Properties.Resources.tanah_texture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 553);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.title);
            this.Controls.Add(this.picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BungaView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nama;
    }
}