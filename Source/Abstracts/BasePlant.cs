using Newtonsoft.Json;
using PBO.Source.Interfaces;
using PBO.Source.Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.Abstracts
{
    public abstract class BasePlant : IBasePlant, ICloneable
    {
        private int statusTumbuh;//0-4
        private int jumlahAir;
        private int jumlahPupuk;
        private bool isTumbuh;

        public BasePlant()
        {
            statusTumbuh = 0;
            jumlahAir = 0;
            jumlahPupuk = 0;
            isTumbuh = false;
        }

        public BasePlant(
            string id,
            string nama,
            int jumlahAir,
            int jumlahPupuk,
            string urlImage = null,
            string base64Image = null) : this()
        {
            ID = id;
            Nama = nama;
            JumlahAirDibutuhkan = jumlahAir;
            JumlahPupukDibutuhkan = jumlahPupuk;

            if (!String.IsNullOrEmpty(urlImage)) PlantImage = PlantImage.FromUrl(urlImage);

            if (!String.IsNullOrEmpty(base64Image)) PlantImage = PlantImage.FromBase64(base64Image);
        }

        public BasePlant(
            string id,
            string nama,
            int jumlahAir,
            int jumlahPupuk,
            PlantImage plantImage) : this()
        {
            ID = id;
            Nama = nama;
            JumlahAirDibutuhkan = jumlahAir;
            JumlahPupukDibutuhkan = jumlahPupuk;
            PlantImage = plantImage;
        }

        [JsonIgnore]
        public int Air => jumlahAir;

        [JsonIgnore]
        public int Pupuk => jumlahPupuk;

        [JsonIgnore]
        public bool IsTumbuh
        {
            get
            {
                var _isTumbuh = isTumbuh;

                if (isTumbuh) isTumbuh = false;

                return _isTumbuh;
            }
        }

        public virtual string ID { get; protected set; }
        public virtual string Nama { get; protected set; }

        [JsonProperty("Air")]
        public virtual int JumlahAirDibutuhkan { get; protected set; }

        [JsonProperty("Pupuk")]
        public virtual int JumlahPupukDibutuhkan { get; protected set; }

        public virtual PlantImage PlantImage { get; protected set; }

        public void beriAir()
        {
            jumlahAir++;
            cekKondisiTumbuh();
        }

        public void beriPupuk()
        {
            jumlahPupuk++;
            cekKondisiTumbuh();
        }

        public string getStatusTumbuhText()
        {
            switch (statusTumbuh)
            {
                case 0:
                    return "Benih";
                case 1:
                    return "Tunas";
                case 2:
                    return "Tanaman Kecil";
                case 3:
                    return "Tanaman Dewasa";
            }

            return "Berbunga";
        }

        public int getStatusTumbuh()
        {
            return statusTumbuh;
        }

        public void displayPlant()
        {
            Console.WriteLine(getStatusTumbuhText());
            Console.WriteLine("Jumlah Air:" + jumlahAir);
            Console.WriteLine("Jumlah Pupuk:" + jumlahPupuk);
        }

        private void cekKondisiTumbuh()
        {
            //cek kecukupan air dan pupuk
            if (jumlahAir >= JumlahAirDibutuhkan && jumlahPupuk >= JumlahPupukDibutuhkan)
            {
                if (!IsTumbuh) tumbuh();
            }
        }

        private void tumbuh()
        {
            if (statusTumbuh < 4)
            {
                jumlahAir = 0;
                jumlahPupuk = 0;
                statusTumbuh++;
                isTumbuh = true;
            }
        }

        public object Clone() => MemberwiseClone();
    }
}
