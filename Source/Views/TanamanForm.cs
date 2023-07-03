using PBO.Source.Abstracts;
using PBO.Source.Lib.Tanaman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO.Source.Views
{
    public partial class TanamanForm : Form
    {
        public BasePlant NewPlant { get; private set; }
        public TanamanForm()
        {
            InitializeComponent();
        }

        private void updateImage()
        {
            var local = LocalImage.Text;
            var url = UrlImage.Text;

            if (!String.IsNullOrEmpty(local) && !String.IsNullOrEmpty(url))
                return; //error

            var isValid = true;

            if(!String.IsNullOrEmpty(local))
            {
                if (File.Exists(local))
                    Picture.Image = Image.FromFile(local);
                else
                    isValid = false;
            }   

            if(!String.IsNullOrEmpty(url))
            {
                if (!Regex.IsMatch(url, @"^(http(s):\/\/.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$"))
                { 
                    isValid = false;
                    return;
                }

                using (var wc = new WebClient())
                {
                    var bytes = wc.DownloadData(url);

                    using (var mem = new MemoryStream(bytes))
                        Picture.Image = Image.FromStream(mem);
                }
            }

            if (!isValid) Picture.Image = Properties.Resources.flower_404;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LocalImage.Text))
                NewPlant = new CustomPlant(Nama.Text, (int)Air.Value, (int)Pupuk.Value, LocalImage.Text);

            if (!String.IsNullOrEmpty(UrlImage.Text))
                NewPlant = new CustomPlant(Nama.Text, (int)Air.Value, (int)Pupuk.Value, null, UrlImage.Text);

            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LocalImage.Text = openFileDialog1.FileName;
            }
        }

        private void Image_TextChanged(object sender, EventArgs e)
        {
            updateImage();
        }
    }
}
