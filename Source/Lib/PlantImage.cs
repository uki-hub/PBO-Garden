using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            _image = image;
            
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, ImageFormat.Png);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                Base64 = base64String;
                Url = urlSource;
            }
        }

        public static PlantImage FromFile(string path)
        {
            if (File.Exists(path))
                return new PlantImage(ResizeImage(Image.FromFile(path)));

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
                        return new PlantImage(ResizeImage(Image.FromStream(mem)), url);
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
            using (MemoryStream m = new MemoryStream())
            {
                _image.Save(m, ImageFormat.Png);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private static Image ResizeImage(Image image) => new Bitmap(image, new Size(150, 125));

    }
}
