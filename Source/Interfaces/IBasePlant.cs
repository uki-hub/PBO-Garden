using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.Interfaces
{
    internal interface IBasePlant
    {
        string Nama { get; }

        int JumlahAirDibutuhkan { get; }

        int JumlahPupukDibutuhkan { get; }

        string FileImage { get; }
        string UrlImage { get; }
        Image EmbeddedImage { get; }

        void beriAir();

        void beriPupuk();

        string getStatusTumbuhText();

        int getStatusTumbuh();

        void displayPlant();
    }
}
