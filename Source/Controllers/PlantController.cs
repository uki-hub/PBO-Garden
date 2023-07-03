using PBO.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using PBO.Source.Lib;
using PBO.Source.Interfaces;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Threading;
using PBO.Source.Views;

namespace PBO.Source.Controllers
{
    internal class PlantController
    {
        private List<BasePlant> _daftarTanaman;
        private Dictionary<int, BasePlant> _tanaman;

        public PlantController()
        {
            _daftarTanaman = new List<BasePlant>(tanamanDefault);

            _tanaman = new Dictionary<int, BasePlant>(9);

            for (int i = 0; i < 9; i++) _tanaman.Add(i, null);
        }

        public List<BasePlant> Tanaman => _daftarTanaman;

        public bool Tanam(WebView2 tanahTanaman, BasePlant tanaman, int posisi)
        {
            if (_tanaman[posisi] != null) return false;

            _tanaman[posisi] = tanaman;

            var dbg = Animation.Plant(posisi, tanaman.JumlahAirDibutuhkan, tanaman.JumlahPupukDibutuhkan, tanaman.Base64Image);

            tanahTanaman.NavigateToString(Animation.Plant(posisi, tanaman.JumlahAirDibutuhkan, tanaman.JumlahPupukDibutuhkan, tanaman.Base64Image));

            return true;
        }

        public void Cabut(int posisi) => _tanaman[posisi] = null;

        public void TambahTanaman(BasePlant plant) => _daftarTanaman.Add(plant);

        public void SetMode(List<WebView2> tanahTanaman, string mode) => ExecuteAllScript(tanahTanaman, $"setMode('{mode}')");

        public void SiramSemua(List<WebView2> tanahTanaman)
        {
            ExecuteAllScript(tanahTanaman, $"setMode('siram')");
            ExecuteAllScript(tanahTanaman, "document.body.click()");
        }

        public void PupukSemua(List<WebView2> tanahTanaman)
        {
            ExecuteAllScript(tanahTanaman, $"setMode('pupuk')");
            ExecuteAllScript(tanahTanaman, "document.body.click()");
        }

        public void CabutSemua(List<WebView2> tanahTanaman)
        {
            ExecuteAllScript(tanahTanaman, $"setMode('cabut')");
            ExecuteAllScript(tanahTanaman, "document.body.click()");
        }

        private void tumbuh(WebView2 tanahTanaman, int posisi)
        {
            var tanaman = _tanaman[posisi];
            var plant = "";

            switch (tanaman.getStatusTumbuh())
            {
                case 0:
                    plant = Lottie.Plant1; //benih
                    break;

                case 1:
                    plant = Lottie.Plant1; //tunas
                    break;

                case 2:
                    plant = Lottie.Plant2; //tumbuhan kecil
                    break;

                case 3:
                    plant = Lottie.Plant3; //tumbuhan besar
                    break;

                case 4:
                    //bunga
                    break;
            }

            Common.SetTimeout(() =>
            {
                if (String.IsNullOrEmpty(plant))
                {
                    tanahTanaman.ExecuteScriptAsync("bunga()");
                    //tanahTanaman.ExecuteScriptAsync("setMode('petik')");
                }
                else
                {
                    tanahTanaman.ExecuteScriptAsync($"setPlant({plant})");
                }
            }, 2000);            
        }

        private void ExecuteAllScript(List<WebView2> tanahTanaman, string script)
        {
            for (int i = 0; i < 9; i++)
            {
                var tanaman = _tanaman[i];
                if (tanaman == null) continue;

                tanahTanaman[i].ExecuteScriptAsync(script);
            }
        }
        public EventHandler<CoreWebView2WebMessageReceivedEventArgs> OnMessageReceived(List<WebView2> tanahTanaman, Action<int> cabutFunction)
        {
            return new EventHandler<CoreWebView2WebMessageReceivedEventArgs>((object sender, CoreWebView2WebMessageReceivedEventArgs args) =>
            {
                var message = args.TryGetWebMessageAsString();

                if (String.IsNullOrEmpty(message)) return;

                var o = JsonConvert.DeserializeObject<dynamic>(message);

                var posisi = (int)o["posisi"];
                var action = (string)o["action"];
                var tanaman = _tanaman[posisi];

                switch (action)
                {
                    case "siram":
                        tanaman.beriAir();
                        break;

                    case "pupuk":
                        tanaman.beriPupuk();
                        break;

                    case "petik":
                        Cabut(posisi);
                        cabutFunction(posisi);
                        new BungaView(tanaman).Show();
                        break;

                    case "cabut":
                        Common.SetTimeout(() =>
                        {
                            Cabut(posisi);
                            cabutFunction(posisi);
                        }, 2000);

                        
                        break;
                }

                if (action == "siram" || action == "pupuk")
                    if (tanaman.IsTumbuh)
                        tumbuh(tanahTanaman[posisi], posisi);
            });
        }

        private List<BasePlant> tanamanDefault => new List<BasePlant> {
                    new Lib.Tanaman.Cosmos(),
                    new Lib.Tanaman.Daisy(),
                    new Lib.Tanaman.Lavender(),
                    new Lib.Tanaman.Lily(),
                    new Lib.Tanaman.Mawar(),
                    new Lib.Tanaman.Tulip(),
        };
    }
}
