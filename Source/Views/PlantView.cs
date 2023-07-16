using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using PBO.Source.Abstracts;
using PBO.Source.Controllers;
using PBO.Source.Interfaces;
using PBO.Source.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO.Source.Views
{
    //tambah kupu2, serangga
    public partial class PlantView : Form
    {
        PlantController controller;
        List<Panel> tanah;
        List<WebView2> tanahTanaman;

        public PlantView()
        {
            controller = new PlantController();
            tanah = new List<Panel>();
            tanahTanaman = new List<WebView2>();

            InitializeComponent();
        }

        private async void PlantView_Load(object sender, EventArgs e)
        {
            tanah = new List<Panel>
            {
                tanah1,
                tanah2,
                tanah3,
                tanah4,
                tanah5,
                tanah6,
                tanah7,
                tanah8,
                tanah9
            };

            for (int i = 0; i < 9; i++)
            {
                var w = new WebView2();
                
                w.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
                w.AllowExternalDrop = false;
                w.BackColor = System.Drawing.Color.White;
                w.CreationProperties = null;
                w.DefaultBackgroundColor = System.Drawing.Color.Transparent;
                w.Dock = System.Windows.Forms.DockStyle.Fill;
                w.Location = new System.Drawing.Point(4, 4);
                w.Name = Guid.NewGuid().ToString();
                w.Size = new System.Drawing.Size(245, 217);
                w.ZoomFactor = 1D;

                w.WebMessageReceived += controller.OnMessageReceived(tanahTanaman, RemoveTanaman);

                var env = await CoreWebView2Environment.CreateAsync(null, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TanamMenanam"));
                await w.EnsureCoreWebView2Async(env);

                tanahTanaman.Add(w);

                tanah[i].DragEnter += Tanah_DragEnter;
                tanah[i].DragDrop += Tanah_DragDrop;
            }

            loading2.Visible = false;

            await LoadTanaman(true);
            loading1.Visible = false;

            await updateStatus();

            //DataAccess.PlantDataAccess.Instance.ObservePlants(p =>
            //{
            //    controller.TambahTanaman(p);
            //    controller.Tanaman.ForEach(t => AddTanaman(t));
            //    updateStatus();
            //});
        }

        private async Task updateStatus()
        {
            var isConnected = await DataAccess.PlantDataAccess.Instance.IsConnected();
            var connectedString = isConnected ? "Connected" : "Disconnected";

            var plantCount = controller.Tanaman.Count;

            StatusLabel.Text = $"📶{connectedString} | 🌱{plantCount}";
        }

        private void AddTanaman(BasePlant tanaman)
        {
            var panel = new Panel();
            panel.BackColor = Color.Transparent;
            panel.Size = new System.Drawing.Size(172, 140);
            panel.Padding = new Padding(4);

            var l = new Label();
            l.Dock = DockStyle.Bottom;
            l.BackColor = Color.Lime;
            l.ForeColor = Color.DarkOliveGreen;
            l.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = tanaman.Nama;

            var p = new PictureBox();
            p.BackColor = Color.Transparent;
            p.Image = tanaman.PlantImage.Image;
            p.Margin = new System.Windows.Forms.Padding(4);
            p.Name = Guid.NewGuid().ToString();
            //p.Size = new System.Drawing.Size(160, 140);
            p.Dock = DockStyle.Fill;
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            p.Cursor = Cursors.Hand;
            p.Tag = tanaman;

            panel.Controls.Add(p);
            panel.Controls.Add(l);

            p.MouseDown += Tanaman_MouseDown;

            TanamanPicker.Controls.Add(panel);
        }

        private void RemoveTanaman(int posisi)
        {
            tanah[posisi].Controls.RemoveAt(0);
            tanahTanaman[posisi].NavigateToString("");
        }

        private void Tanaman_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((PictureBox)sender, DragDropEffects.All);
        }

        private void Tanah_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Tanah_DragDrop(object sender, DragEventArgs e)
        {
            var _tanah = (Panel)sender;
            var tanaman = (BasePlant)((PictureBox)e.Data.GetData(typeof(PictureBox))).Tag;
            tanaman = (BasePlant)tanaman.Clone();

            var posisi = Convert.ToInt32(_tanah.Tag) - 1;
            var _tanahTanaman = tanahTanaman[posisi];

            _tanah.Controls.Add(tanahTanaman[posisi]);

            controller.Tanam(_tanahTanaman, tanaman, posisi);
        }

        private void Siram_Click(object sender, EventArgs e)
        {
            controller.SetMode(tanahTanaman, "siram");
        }

        private void Pupuk_Click(object sender, EventArgs e)
        {
            controller.SetMode(tanahTanaman, "pupuk");
        }

        private void Cabut_Click(object sender, EventArgs e)
        {
            controller.SetMode(tanahTanaman, "cabut");
        }

        private void SiramSemua_Click(object sender, EventArgs e)
        {
            controller.SiramSemua(tanahTanaman);
        }

        private void PupukSemua_Click(object sender, EventArgs e)
        {
            controller.PupukSemua(tanahTanaman);
        }

        private void CabutSemua_Click(object sender, EventArgs e)
        {
            controller.CabutSemua(tanahTanaman);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Cabut(0);
            RemoveTanaman(0);
        }

        private async void AddTumbuhan_Click(object sender, EventArgs e)
        {
            using (var form = new TanamanForm())
            {
                var result = form.ShowDialog();

                if (form.NewPlant == null) return;

                controller.TambahTanaman(form.NewPlant);
                AddTanaman(form.NewPlant);

                await DataAccess.PlantDataAccess.Instance.InsertPlant(form.NewPlant);
            }
        }

        private async Task LoadTanaman(bool isInital)
        {
            var storedTanaman = await DataAccess.PlantDataAccess.Instance.GetPlants();
            var diff = new List<BasePlant>();

            foreach (var tanaman in storedTanaman) 
                if (!controller.Tanaman.Any(t => t.ID == tanaman.ID)) diff.Add(tanaman);

            controller.TambahTanaman(diff);

            if (isInital) controller.TanamanDefault.ForEach(t => AddTanaman(t));
            diff.ForEach(t => AddTanaman(t));
        }

        private async void Refresher_Tick(object sender, EventArgs e)
        {
            await updateStatus();
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            Refresh.ForeColor = Color.MediumSeaGreen;
        }

        private void Refresh_MouseLeave(object sender, EventArgs e)
        {
            Refresh.ForeColor = Color.SpringGreen;

        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"{StatusLabel.Text} | Refreshing...";
            await LoadTanaman(false);
            await updateStatus();

        }
    }
}
