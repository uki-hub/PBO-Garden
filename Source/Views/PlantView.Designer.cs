using PBO.Source.Controllers;

namespace PBO.Source.Views
{
    partial class PlantView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantView));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.AlatKebun = new System.Windows.Forms.GroupBox();
            this.AddTumbuhan = new System.Windows.Forms.Button();
            this.CabutSemua = new System.Windows.Forms.Button();
            this.PupukSemua = new System.Windows.Forms.Button();
            this.SiramSemua = new System.Windows.Forms.Button();
            this.Cabut = new System.Windows.Forms.Button();
            this.Pupuk = new System.Windows.Forms.Button();
            this.Siram = new System.Windows.Forms.Button();
            this.TanamanPicker = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LayoutGarden = new System.Windows.Forms.TableLayoutPanel();
            this.tanah9 = new System.Windows.Forms.Panel();
            this.tanah8 = new System.Windows.Forms.Panel();
            this.tanah7 = new System.Windows.Forms.Panel();
            this.tanah6 = new System.Windows.Forms.Panel();
            this.tanah5 = new System.Windows.Forms.Panel();
            this.tanah4 = new System.Windows.Forms.Panel();
            this.tanah3 = new System.Windows.Forms.Panel();
            this.tanah2 = new System.Windows.Forms.Panel();
            this.tanah1 = new System.Windows.Forms.Panel();
            this.loading1 = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loading2gif = new System.Windows.Forms.PictureBox();
            this.loading2 = new System.Windows.Forms.Panel();
            this.loadingLabel2 = new System.Windows.Forms.Label();
            this.loading1gif = new System.Windows.Forms.PictureBox();
            this.copyright = new System.Windows.Forms.Label();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.LayoutMain.SuspendLayout();
            this.LayoutToolbar.SuspendLayout();
            this.AlatKebun.SuspendLayout();
            this.LayoutTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.LayoutGarden.SuspendLayout();
            this.loading1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading2gif)).BeginInit();
            this.loading2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading1gif)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.LayoutMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LayoutMain.ColumnCount = 2;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.LayoutMain.Controls.Add(this.LayoutToolbar, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutGarden, 1, 0);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 1;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Size = new System.Drawing.Size(1261, 673);
            this.LayoutMain.TabIndex = 0;
            // 
            // LayoutToolbar
            // 
            this.LayoutToolbar.BackColor = System.Drawing.Color.Transparent;
            this.LayoutToolbar.ColumnCount = 1;
            this.LayoutToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutToolbar.Controls.Add(this.AlatKebun, 0, 3);
            this.LayoutToolbar.Controls.Add(this.TanamanPicker, 0, 2);
            this.LayoutToolbar.Controls.Add(this.LayoutTitle, 0, 0);
            this.LayoutToolbar.Controls.Add(this.StatusLabel, 0, 1);
            this.LayoutToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutToolbar.Location = new System.Drawing.Point(0, 0);
            this.LayoutToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutToolbar.Name = "LayoutToolbar";
            this.LayoutToolbar.RowCount = 4;
            this.LayoutToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.9896F));
            this.LayoutToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.15156F));
            this.LayoutToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutToolbar.Size = new System.Drawing.Size(504, 673);
            this.LayoutToolbar.TabIndex = 10;
            // 
            // AlatKebun
            // 
            this.AlatKebun.Controls.Add(this.AddTumbuhan);
            this.AlatKebun.Controls.Add(this.CabutSemua);
            this.AlatKebun.Controls.Add(this.PupukSemua);
            this.AlatKebun.Controls.Add(this.SiramSemua);
            this.AlatKebun.Controls.Add(this.Cabut);
            this.AlatKebun.Controls.Add(this.Pupuk);
            this.AlatKebun.Controls.Add(this.Siram);
            this.AlatKebun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlatKebun.ForeColor = System.Drawing.Color.LightGreen;
            this.AlatKebun.Location = new System.Drawing.Point(8, 498);
            this.AlatKebun.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.AlatKebun.Name = "AlatKebun";
            this.AlatKebun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlatKebun.Size = new System.Drawing.Size(488, 173);
            this.AlatKebun.TabIndex = 14;
            this.AlatKebun.TabStop = false;
            this.AlatKebun.Text = "Alat Perkebunan";
            // 
            // AddTumbuhan
            // 
            this.AddTumbuhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTumbuhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTumbuhan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTumbuhan.ForeColor = System.Drawing.Color.Green;
            this.AddTumbuhan.Image = global::PBO.Properties.Resources.add_plant;
            this.AddTumbuhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddTumbuhan.Location = new System.Drawing.Point(364, 31);
            this.AddTumbuhan.Name = "AddTumbuhan";
            this.AddTumbuhan.Size = new System.Drawing.Size(118, 126);
            this.AddTumbuhan.TabIndex = 6;
            this.AddTumbuhan.Text = "Tambah Tumbuhan";
            this.AddTumbuhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddTumbuhan.UseVisualStyleBackColor = true;
            this.AddTumbuhan.Click += new System.EventHandler(this.AddTumbuhan_Click);
            // 
            // CabutSemua
            // 
            this.CabutSemua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CabutSemua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CabutSemua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabutSemua.ForeColor = System.Drawing.Color.MediumBlue;
            this.CabutSemua.Image = global::PBO.Properties.Resources.cabut;
            this.CabutSemua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CabutSemua.Location = new System.Drawing.Point(248, 97);
            this.CabutSemua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CabutSemua.Name = "CabutSemua";
            this.CabutSemua.Size = new System.Drawing.Size(110, 70);
            this.CabutSemua.TabIndex = 5;
            this.CabutSemua.TabStop = false;
            this.CabutSemua.Text = "Semua";
            this.CabutSemua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CabutSemua.UseVisualStyleBackColor = false;
            this.CabutSemua.Click += new System.EventHandler(this.CabutSemua_Click);
            // 
            // PupukSemua
            // 
            this.PupukSemua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PupukSemua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PupukSemua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PupukSemua.ForeColor = System.Drawing.Color.MediumBlue;
            this.PupukSemua.Image = global::PBO.Properties.Resources.pupuk;
            this.PupukSemua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PupukSemua.Location = new System.Drawing.Point(127, 97);
            this.PupukSemua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PupukSemua.Name = "PupukSemua";
            this.PupukSemua.Size = new System.Drawing.Size(110, 70);
            this.PupukSemua.TabIndex = 4;
            this.PupukSemua.TabStop = false;
            this.PupukSemua.Text = "Semua";
            this.PupukSemua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PupukSemua.UseVisualStyleBackColor = false;
            this.PupukSemua.Click += new System.EventHandler(this.PupukSemua_Click);
            // 
            // SiramSemua
            // 
            this.SiramSemua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SiramSemua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SiramSemua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiramSemua.ForeColor = System.Drawing.Color.MediumBlue;
            this.SiramSemua.Image = global::PBO.Properties.Resources.siram;
            this.SiramSemua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SiramSemua.Location = new System.Drawing.Point(5, 97);
            this.SiramSemua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SiramSemua.Name = "SiramSemua";
            this.SiramSemua.Size = new System.Drawing.Size(110, 70);
            this.SiramSemua.TabIndex = 3;
            this.SiramSemua.TabStop = false;
            this.SiramSemua.Text = "Semua";
            this.SiramSemua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SiramSemua.UseVisualStyleBackColor = false;
            this.SiramSemua.Click += new System.EventHandler(this.SiramSemua_Click);
            // 
            // Cabut
            // 
            this.Cabut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cabut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cabut.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabut.ForeColor = System.Drawing.Color.MediumBlue;
            this.Cabut.Image = global::PBO.Properties.Resources.cabut;
            this.Cabut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cabut.Location = new System.Drawing.Point(248, 21);
            this.Cabut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cabut.Name = "Cabut";
            this.Cabut.Size = new System.Drawing.Size(110, 70);
            this.Cabut.TabIndex = 2;
            this.Cabut.TabStop = false;
            this.Cabut.Text = "Cabut";
            this.Cabut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cabut.UseVisualStyleBackColor = false;
            this.Cabut.Click += new System.EventHandler(this.Cabut_Click);
            // 
            // Pupuk
            // 
            this.Pupuk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pupuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pupuk.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pupuk.ForeColor = System.Drawing.Color.MediumBlue;
            this.Pupuk.Image = global::PBO.Properties.Resources.pupuk;
            this.Pupuk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pupuk.Location = new System.Drawing.Point(127, 21);
            this.Pupuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pupuk.Name = "Pupuk";
            this.Pupuk.Size = new System.Drawing.Size(110, 70);
            this.Pupuk.TabIndex = 1;
            this.Pupuk.TabStop = false;
            this.Pupuk.Text = "Pupuk";
            this.Pupuk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pupuk.UseVisualStyleBackColor = false;
            this.Pupuk.Click += new System.EventHandler(this.Pupuk_Click);
            // 
            // Siram
            // 
            this.Siram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Siram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siram.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siram.ForeColor = System.Drawing.Color.MediumBlue;
            this.Siram.Image = global::PBO.Properties.Resources.siram;
            this.Siram.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Siram.Location = new System.Drawing.Point(5, 21);
            this.Siram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Siram.Name = "Siram";
            this.Siram.Size = new System.Drawing.Size(110, 70);
            this.Siram.TabIndex = 0;
            this.Siram.TabStop = false;
            this.Siram.Text = "Siram";
            this.Siram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Siram.UseVisualStyleBackColor = false;
            this.Siram.Click += new System.EventHandler(this.Siram_Click);
            // 
            // TanamanPicker
            // 
            this.TanamanPicker.AutoScroll = true;
            this.TanamanPicker.BackColor = System.Drawing.Color.LimeGreen;
            this.TanamanPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TanamanPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanamanPicker.Location = new System.Drawing.Point(0, 100);
            this.TanamanPicker.Margin = new System.Windows.Forms.Padding(0);
            this.TanamanPicker.Name = "TanamanPicker";
            this.TanamanPicker.Size = new System.Drawing.Size(504, 396);
            this.TanamanPicker.TabIndex = 13;
            // 
            // LayoutTitle
            // 
            this.LayoutTitle.ColumnCount = 2;
            this.LayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.LayoutTitle.Controls.Add(this.Title, 1, 0);
            this.LayoutTitle.Controls.Add(this.iconPicture, 0, 0);
            this.LayoutTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTitle.Location = new System.Drawing.Point(3, 3);
            this.LayoutTitle.Name = "LayoutTitle";
            this.LayoutTitle.RowCount = 1;
            this.LayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTitle.Size = new System.Drawing.Size(498, 61);
            this.LayoutTitle.TabIndex = 15;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.LightGreen;
            this.Title.Location = new System.Drawing.Point(77, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(418, 61);
            this.Title.TabIndex = 19;
            this.Title.Text = "Tanam Menanam";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPicture
            // 
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPicture.Image = global::PBO.Properties.Resources.icon;
            this.iconPicture.Location = new System.Drawing.Point(3, 3);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(68, 55);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPicture.TabIndex = 4;
            this.iconPicture.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.StatusLabel.Location = new System.Drawing.Point(3, 67);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(498, 33);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LayoutGarden
            // 
            this.LayoutGarden.BackColor = System.Drawing.Color.Transparent;
            this.LayoutGarden.BackgroundImage = global::PBO.Properties.Resources.tanah_texture;
            this.LayoutGarden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayoutGarden.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutGarden.ColumnCount = 3;
            this.LayoutGarden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.Controls.Add(this.tanah9, 2, 2);
            this.LayoutGarden.Controls.Add(this.tanah8, 1, 2);
            this.LayoutGarden.Controls.Add(this.tanah7, 0, 2);
            this.LayoutGarden.Controls.Add(this.tanah6, 2, 1);
            this.LayoutGarden.Controls.Add(this.tanah5, 1, 1);
            this.LayoutGarden.Controls.Add(this.tanah4, 0, 1);
            this.LayoutGarden.Controls.Add(this.tanah3, 2, 0);
            this.LayoutGarden.Controls.Add(this.tanah2, 1, 0);
            this.LayoutGarden.Controls.Add(this.tanah1, 0, 0);
            this.LayoutGarden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutGarden.Location = new System.Drawing.Point(504, 0);
            this.LayoutGarden.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutGarden.Name = "LayoutGarden";
            this.LayoutGarden.RowCount = 3;
            this.LayoutGarden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutGarden.Size = new System.Drawing.Size(757, 673);
            this.LayoutGarden.TabIndex = 13;
            // 
            // tanah9
            // 
            this.tanah9.AllowDrop = true;
            this.tanah9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah9.Location = new System.Drawing.Point(508, 451);
            this.tanah9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah9.Name = "tanah9";
            this.tanah9.Size = new System.Drawing.Size(245, 219);
            this.tanah9.TabIndex = 27;
            this.tanah9.Tag = "9";
            // 
            // tanah8
            // 
            this.tanah8.AllowDrop = true;
            this.tanah8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah8.Location = new System.Drawing.Point(256, 451);
            this.tanah8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah8.Name = "tanah8";
            this.tanah8.Size = new System.Drawing.Size(245, 219);
            this.tanah8.TabIndex = 26;
            this.tanah8.Tag = "8";
            // 
            // tanah7
            // 
            this.tanah7.AllowDrop = true;
            this.tanah7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah7.Location = new System.Drawing.Point(4, 451);
            this.tanah7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah7.Name = "tanah7";
            this.tanah7.Size = new System.Drawing.Size(245, 219);
            this.tanah7.TabIndex = 25;
            this.tanah7.Tag = "7";
            // 
            // tanah6
            // 
            this.tanah6.AllowDrop = true;
            this.tanah6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah6.Location = new System.Drawing.Point(508, 227);
            this.tanah6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah6.Name = "tanah6";
            this.tanah6.Size = new System.Drawing.Size(245, 219);
            this.tanah6.TabIndex = 24;
            this.tanah6.Tag = "6";
            // 
            // tanah5
            // 
            this.tanah5.AllowDrop = true;
            this.tanah5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah5.Location = new System.Drawing.Point(256, 227);
            this.tanah5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah5.Name = "tanah5";
            this.tanah5.Size = new System.Drawing.Size(245, 219);
            this.tanah5.TabIndex = 23;
            this.tanah5.Tag = "5";
            // 
            // tanah4
            // 
            this.tanah4.AllowDrop = true;
            this.tanah4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah4.Location = new System.Drawing.Point(4, 227);
            this.tanah4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah4.Name = "tanah4";
            this.tanah4.Size = new System.Drawing.Size(245, 219);
            this.tanah4.TabIndex = 22;
            this.tanah4.Tag = "4";
            // 
            // tanah3
            // 
            this.tanah3.AllowDrop = true;
            this.tanah3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah3.Location = new System.Drawing.Point(508, 3);
            this.tanah3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah3.Name = "tanah3";
            this.tanah3.Size = new System.Drawing.Size(245, 219);
            this.tanah3.TabIndex = 21;
            this.tanah3.Tag = "3";
            // 
            // tanah2
            // 
            this.tanah2.AllowDrop = true;
            this.tanah2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah2.Location = new System.Drawing.Point(256, 3);
            this.tanah2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah2.Name = "tanah2";
            this.tanah2.Size = new System.Drawing.Size(245, 219);
            this.tanah2.TabIndex = 20;
            this.tanah2.Tag = "2";
            // 
            // tanah1
            // 
            this.tanah1.AllowDrop = true;
            this.tanah1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanah1.Location = new System.Drawing.Point(4, 3);
            this.tanah1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanah1.Name = "tanah1";
            this.tanah1.Size = new System.Drawing.Size(245, 219);
            this.tanah1.TabIndex = 19;
            this.tanah1.Tag = "1";
            // 
            // loading1
            // 
            this.loading1.BackColor = System.Drawing.Color.LimeGreen;
            this.loading1.Controls.Add(this.loadingLabel);
            this.loading1.Controls.Add(this.loading2gif);
            this.loading1.Location = new System.Drawing.Point(0, 100);
            this.loading1.Margin = new System.Windows.Forms.Padding(4);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(504, 369);
            this.loading1.TabIndex = 3;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.loadingLabel.Location = new System.Drawing.Point(196, 272);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(103, 23);
            this.loadingLabel.TabIndex = 2;
            this.loadingLabel.Text = "Loading...";
            // 
            // loading2gif
            // 
            this.loading2gif.Image = global::PBO.Properties.Resources.loading;
            this.loading2gif.Location = new System.Drawing.Point(135, 95);
            this.loading2gif.Margin = new System.Windows.Forms.Padding(4);
            this.loading2gif.Name = "loading2gif";
            this.loading2gif.Size = new System.Drawing.Size(228, 200);
            this.loading2gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading2gif.TabIndex = 1;
            this.loading2gif.TabStop = false;
            // 
            // loading2
            // 
            this.loading2.Controls.Add(this.loadingLabel2);
            this.loading2.Controls.Add(this.loading1gif);
            this.loading2.Dock = System.Windows.Forms.DockStyle.Right;
            this.loading2.Location = new System.Drawing.Point(508, 0);
            this.loading2.Margin = new System.Windows.Forms.Padding(4);
            this.loading2.Name = "loading2";
            this.loading2.Size = new System.Drawing.Size(753, 673);
            this.loading2.TabIndex = 2;
            // 
            // loadingLabel2
            // 
            this.loadingLabel2.AutoSize = true;
            this.loadingLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel2.ForeColor = System.Drawing.Color.PaleGreen;
            this.loadingLabel2.Location = new System.Drawing.Point(330, 423);
            this.loadingLabel2.Name = "loadingLabel2";
            this.loadingLabel2.Size = new System.Drawing.Size(103, 23);
            this.loadingLabel2.TabIndex = 3;
            this.loadingLabel2.Text = "Loading...";
            // 
            // loading1gif
            // 
            this.loading1gif.Image = global::PBO.Properties.Resources.loading;
            this.loading1gif.Location = new System.Drawing.Point(252, 208);
            this.loading1gif.Margin = new System.Windows.Forms.Padding(4);
            this.loading1gif.Name = "loading1gif";
            this.loading1gif.Size = new System.Drawing.Size(265, 238);
            this.loading1gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading1gif.TabIndex = 0;
            this.loading1gif.TabStop = false;
            this.loading1gif.WaitOnLoad = true;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.Transparent;
            this.copyright.ForeColor = System.Drawing.Color.LimeGreen;
            this.copyright.Location = new System.Drawing.Point(85, 50);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(80, 17);
            this.copyright.TabIndex = 8;
            this.copyright.Text = "© 2023 UKI";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Refresher
            // 
            this.Refresher.Enabled = true;
            this.Refresher.Interval = 2500;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // PlantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.loading2);
            this.Controls.Add(this.LayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlantView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanam Menanam";
            this.Load += new System.EventHandler(this.PlantView_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutToolbar.ResumeLayout(false);
            this.LayoutToolbar.PerformLayout();
            this.AlatKebun.ResumeLayout(false);
            this.LayoutTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.LayoutGarden.ResumeLayout(false);
            this.loading1.ResumeLayout(false);
            this.loading1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading2gif)).EndInit();
            this.loading2.ResumeLayout(false);
            this.loading2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading1gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutToolbar;
        private System.Windows.Forms.FlowLayoutPanel TanamanPicker;
        private System.Windows.Forms.TableLayoutPanel LayoutGarden;
        private System.Windows.Forms.GroupBox AlatKebun;
        private System.Windows.Forms.Panel tanah9;
        private System.Windows.Forms.Panel tanah8;
        private System.Windows.Forms.Panel tanah7;
        private System.Windows.Forms.Panel tanah6;
        private System.Windows.Forms.Panel tanah5;
        private System.Windows.Forms.Panel tanah4;
        private System.Windows.Forms.Panel tanah3;
        private System.Windows.Forms.Panel tanah2;
        private System.Windows.Forms.Button Siram;
        private System.Windows.Forms.Button Cabut;
        private System.Windows.Forms.Button Pupuk;
        private System.Windows.Forms.Button SiramSemua;
        private System.Windows.Forms.Button PupukSemua;
        private System.Windows.Forms.Button CabutSemua;
        private System.Windows.Forms.Panel tanah1;
        private System.Windows.Forms.Panel loading1;
        private System.Windows.Forms.Panel loading2;
        private System.Windows.Forms.PictureBox loading2gif;
        private System.Windows.Forms.PictureBox loading1gif;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label loadingLabel2;
        private System.Windows.Forms.TableLayoutPanel LayoutTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button AddTumbuhan;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Timer Refresher;
    }
}