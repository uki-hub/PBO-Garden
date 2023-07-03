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
        public override string Nama => "Mawar";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 2;

        public override Image EmbeddedImage { get => Properties.Resources.Rose; }
    }

    internal class Cosmos : BasePlant
    {
        public override string Nama => "Cosmos";

        public override int JumlahAirDibutuhkan => 4;

        public override int JumlahPupukDibutuhkan => 2;

        public override Image EmbeddedImage { get => Properties.Resources.Cosmos;  }
    }

    internal class Daisy : BasePlant
    {
        public override string Nama => "Daisy";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 1;

        public override Image EmbeddedImage { get => Properties.Resources.Daisy; }

    }

    internal class Lavender : BasePlant
    {
        public override string Nama => "Lavender";

        public override int JumlahAirDibutuhkan => 4;

        public override int JumlahPupukDibutuhkan => 1;

        public override Image EmbeddedImage { get => Properties.Resources.Lavender; }

    }

    internal class Lily : BasePlant
    {
        public override string Nama => "Lily";

        public override int JumlahAirDibutuhkan => 3;

        public override int JumlahPupukDibutuhkan => 2;

        public override Image EmbeddedImage { get => Properties.Resources.Lily; }

    }

    internal class Tulip : BasePlant
    {
        public override string Nama => "Tulip";

        public override int JumlahAirDibutuhkan => 2;

        public override int JumlahPupukDibutuhkan => 1;

        public override Image EmbeddedImage { get => Properties.Resources.Tulip; }

    }

    internal class CustomPlant : BasePlant
    {
        public CustomPlant(string nama, int jumlahAir, int jumlahPupuk, string localImage = null, string urlImage = null) 
            : base(nama, jumlahAir, jumlahPupuk, localImage, urlImage)
        { }
    }
}
