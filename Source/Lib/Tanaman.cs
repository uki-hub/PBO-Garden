using PBO.Source.Abstracts;
using PBO.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.Lib.Tanaman
{
    internal class Mawar : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Rose);

        public override string ID { get => "Mawar"; }
        public override string Nama => "Mawar";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 2;

        public override PlantImage PlantImage { get => plantImage; }
    }

    internal class Cosmos : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Cosmos);

        public override string ID { get => "Cosmos"; }

        public override string Nama => "Cosmos";

        public override int JumlahAirDibutuhkan => 4;

        public override int JumlahPupukDibutuhkan => 2;

        public override PlantImage PlantImage { get => plantImage; }
    }

    internal class Daisy : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Daisy);

        public override string ID { get => "Daisy"; }

        public override string Nama => "Daisy";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 1;

        public override PlantImage PlantImage { get => plantImage; }

    }

    internal class Lavender : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Lavender);

        public override string ID { get => "Lavender"; }
        public override string Nama => "Lavender";

        public override int JumlahAirDibutuhkan => 4;

        public override int JumlahPupukDibutuhkan => 1;

        public override PlantImage PlantImage { get => plantImage; }

    }

    internal class Lily : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Lily);

        public override string ID { get => "Lily"; }

        public override string Nama => "Lily";

        public override int JumlahAirDibutuhkan => 3;

        public override int JumlahPupukDibutuhkan => 2;

        public override PlantImage PlantImage { get => plantImage; }

    }

    internal class Tulip : BasePlant
    {
        private PlantImage plantImage = new PlantImage(Properties.Resources.Tulip);

        public override string ID { get => "Tulip"; }
        public override string Nama => "Tulip";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 1;

        public override PlantImage PlantImage { get => plantImage; }

    }

    internal class CustomPlant : BasePlant
    {
        public CustomPlant(string id, string nama, int jumlahAir, int jumlahPupuk, string urlImage = null, string base64Image = null) 
            : base(id, nama, jumlahAir, jumlahPupuk, urlImage, base64Image)
        { }

        public CustomPlant(string id, string nama, int jumlahAir, int jumlahPupuk, PlantImage plantImage)
            : base(id, nama, jumlahAir, jumlahPupuk, plantImage)
        { }
    }
}
