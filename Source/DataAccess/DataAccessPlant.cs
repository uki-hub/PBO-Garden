using Firebase.Database;
using Newtonsoft.Json;
using PBO.Source.Abstracts;
using PBO.Source.Controllers;
using PBO.Source.Lib;
using PBO.Source.Lib.Tanaman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.DataAccess
{
    internal class PlantDataAccess
    {
        private static PlantDataAccess instance = null;
        private static readonly object padlock = new object();

        public static PlantDataAccess Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PlantDataAccess();
                    }

                    return instance;
                }
            }
        }

        private static FirebaseClient client;

        public PlantDataAccess()
        {
            client = new FirebaseClient(
              "https://tanammenanam-b26e0-default-rtdb.asia-southeast1.firebasedatabase.app",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult("sJ6Zf5c13ToMGp6dTh8tqbRWR8mksJq4WcuT1bB6")
                  
              });
        }

        public async Task InsertPlant(BasePlant plant)
        {
            await client.Child("plants").PostAsync(JsonConvert.SerializeObject(plant));
        }

        public async Task<List<BasePlant>> GetPlants()
        {
            try
            {
                return ParsePlantsJson(await client.Child("plants").OnceAsJsonAsync());
            }
            catch (Exception)
            {
                return new List<BasePlant>();
            }
            
        }

        public void ObservePlants(Action<List<BasePlant>> onChange)
        {
            //var result = new List<BasePlant>();

            //client.Child("plants").AsObservable<string>().Subscribe(r => {
            //    onChange(ParsePlantsJson(r.Object));
            //});
        }

        public async Task<Boolean> IsConnected()
        {
            try
            {
                return (await client.Child("ok").OnceAsJsonAsync()) == "1";
            }
            catch (Exception)
            {
                return false;
            }            
        }

        private List<BasePlant> ParsePlantsJson(string json)
        {
            var result = new List<BasePlant>();

            if (String.IsNullOrEmpty(json)) return result;

            var dynamicList = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);

            if (dynamicList != null)
                foreach (var d in dynamicList)
                {
                    var id = (string)d.Value["ID"];
                    var nama = (string)d.Value["Nama"];
                    var air = (int)d.Value["Air"];
                    var pupuk = (int)d.Value["Pupuk"];
                    var url = (string)d.Value["PlantImage"]["Url"];
                    var base64 = (string)d.Value["PlantImage"]["Base64"];


                    if (!string.IsNullOrEmpty(url))
                        result.Add(new CustomPlant(id, nama, air, pupuk, url));
                    else
                        result.Add(new CustomPlant(id, nama, air, pupuk, null, base64));
                }

            return result;
        } 
    }
}
