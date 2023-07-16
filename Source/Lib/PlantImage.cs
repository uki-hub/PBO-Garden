using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.Lib
{
    public class PlantImage
    {
        private Image _image;

        public PlantImage(Image image, string urlSource = null)
        {
            _image = ResizeImage(image);
            
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, ImageFormat.Png);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                
                if(String.IsNullOrEmpty(urlSource)) Base64 = base64String;
                
                Url = urlSource;
            }
        }

        public static PlantImage FromFile(string path)
        {
            if (File.Exists(path))
                return new PlantImage(Image.FromFile(path));

            throw new Exception("File Does not exist");
        }

        public static PlantImage FromUrl(string url)
        {
            try
            {
                using (var wc = new WebClient())
                {
                    var bytes = wc.DownloadData(url);

                    using (var mem = new MemoryStream(bytes))
                        return new PlantImage(Image.FromStream(mem), url);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public static PlantImage FromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);

            using (var mem = new MemoryStream(bytes))
                return new PlantImage(Image.FromStream(mem));
        }

        [JsonIgnore]
        public Image Image => _image;

        public string Base64 { get; private set; }
        public string Url { get; private set; }

        public string ConvertToBase64()
        {
            using (var m = new MemoryStream())
            {
                _image.Save(m, ImageFormat.Png);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private static Image ResizeImage(Image image)
        {
            var b = new Bitmap(150, 125, PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage((Image)b))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(image, 0, 0, 150, 125);
            }

            b.MakeTransparent();

            return b;
        }

    }
}
