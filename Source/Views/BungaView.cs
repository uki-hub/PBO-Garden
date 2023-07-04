using PBO.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO.Source.Views
{
    public partial class BungaView : Form
    {
        public BungaView(BasePlant plant)
        {
            InitializeComponent();

            picture.Image = plant.PlantImage.Image;
            nama.Text = plant.Nama;
            this.Text = $"★☆ {plant.Nama} ☆★";
        }
    }
}
