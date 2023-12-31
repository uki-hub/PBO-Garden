﻿using PBO.Source.Lib;
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
        string ID { get; }
        string Nama { get; }

        int JumlahAirDibutuhkan { get; }

        int JumlahPupukDibutuhkan { get; }

        PlantImage PlantImage { get;  }

        void beriAir();

        void beriPupuk();

        string getStatusTumbuhText();

        int getStatusTumbuh();

        void displayPlant();
    }
}
