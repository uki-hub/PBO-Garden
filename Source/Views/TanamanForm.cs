using PBO.Source.Abstracts;
using PBO.Source.Lib;
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

            var isValid = true;

            if (!String.IsNullOrEmpty(local) && !String.IsNullOrEmpty(url))
            {
                isValid = false;
                ErrorMessage.Text = "Cannot use both of them please choose only local or url image only";
            }

            if (isValid && !String.IsNullOrEmpty(local))
            {
                if (File.Exists(local))
                {
                    Picture.Image = Image.FromFile(local);
                }
                else
                {
                    isValid = false;
                    ErrorMessage.Text = "File Does not exists";
                }

            }

            if (isValid && !String.IsNullOrEmpty(url))
            {
                if (!Regex.IsMatch(url, @"^(http(s):\/\/.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$"))
                {
                    isValid = false;
                    return;
                }

                try
                {
                    using (var wc = new WebClient())
                    {
                        var bytes = wc.DownloadData(url);

                        using (var mem = new MemoryStream(bytes))
                            Picture.Image = Image.FromStream(mem);
                    }
                }
                catch (Exception e)
                {
                    isValid = false;
                    ErrorMessage.Text = e.Message;
                }

            }

            if (!isValid)
            {
                //Picture.Image = Properties.Resources.flower_404;
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = false;
            }

        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            var id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

            if (!String.IsNullOrEmpty(LocalImage.Text))
                NewPlant = new CustomPlant(id, Nama.Text, (int)Air.Value, (int)Pupuk.Value, PlantImage.FromFile(LocalImage.Text));

            if (!String.IsNullOrEmpty(UrlImage.Text))
                NewPlant = new CustomPlant(id, Nama.Text, (int)Air.Value, (int)Pupuk.Value, UrlImage.Text);

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
