using PBO.Source.Interfaces;
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
        private Image plantImage;

        public BasePlant()
        {
            statusTumbuh = 0;
            jumlahAir = 0;
            jumlahPupuk = 0;
            isTumbuh = false;
        }

        public BasePlant(
            string nama, 
            int jumlahAir, 
            int jumlahPupuk, 
            string fileImage = null,  
            string urlImage = null) : this()
        {
            Nama = nama;
            JumlahAirDibutuhkan = jumlahAir;
            JumlahPupukDibutuhkan = jumlahPupuk;

            if(!String.IsNullOrEmpty(fileImage)) FileImage = fileImage;

            if(!String.IsNullOrEmpty(urlImage)) UrlImage = urlImage;
        }

        public int Air => jumlahAir;
        public int Pupuk => jumlahPupuk;

        public bool IsTumbuh
        {
            get
            {
                var _isTumbuh = isTumbuh;

                if (isTumbuh) isTumbuh = false;

                return _isTumbuh;
            }
        }

        public virtual string Nama { get; protected set; }
        public virtual int JumlahAirDibutuhkan { get; protected set; }
        public virtual int JumlahPupukDibutuhkan { get; protected set; }
        public virtual string FileImage { get; protected set; }
        public virtual string UrlImage { get; protected set; }
        public virtual Image EmbeddedImage { get; protected set; }

        public Image PlantImage
        {
            get
            {
                if (plantImage != null) return plantImage;

                Image image = null;

                if(!string.IsNullOrEmpty(FileImage))
                    image = Bitmap.FromFile(FileImage);

                if (image == null && !string.IsNullOrEmpty(UrlImage))
                    using(var wc = new WebClient())
                    {
                        var bytes = wc.DownloadData(UrlImage);

                        using (var mem = new MemoryStream(bytes))
                            image = Image.FromStream(mem);
                    }

                if (image == null)
                    image = EmbeddedImage;

                if (image == null)
                    image = Properties.Resources.flower_404;

                plantImage = image;

                return image;
            }
        }

        public string Base64Image
        {
            get {
                var image = new Bitmap(PlantImage, new Size(150, 125));
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, ImageFormat.Png);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }

        }

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
