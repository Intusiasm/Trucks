using Library.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Library.Database
{
    /// <summary>
    /// Class to access to json database.
    /// </summary>
    static public class JsonDB
    {
        /// <summary>
        /// The directory path to root file of the application.
        /// </summary>
        private static string PATH = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        /// <summary>
        /// Name of json database file.
        /// </summary>
        private static string FILENAME = "Trucks.json";
        
        /// <summary>
        /// Full path of json database file.
        /// </summary>
        public static string FULLPATH = PATH + $"/{FILENAME}";

        /// <summary>
        /// Adds <see cref="Truck"/> to json database.
        /// </summary>
        /// <param name="newTruck"></param>
        static public void Add(Truck newTruck)
        {
            string jsonString = "";
            var truck = new List<Truck>();

            if (File.Exists(FULLPATH))
            {

                JsonTextReader reader = new JsonTextReader(new StreamReader(FULLPATH));

                reader.SupportMultipleContent = true;

                while (true)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    JsonSerializer serializer = new JsonSerializer();
                    truck.AddRange(serializer.Deserialize<Truck[]>(reader));
                    
                    if (truck.Count != 0)
                    {
                        var lastTruck = truck.Last();
                        newTruck.Id = lastTruck.Id + 1;
                    }
                    else
                    {
                        newTruck.Id = 1;
                    }
                    truck.Add(newTruck);
                }

                reader.Close();
            }
            else
            {
                newTruck.Id = 1;
                truck.Add(newTruck);
            }

            if (truck.First() == null)
            {
                newTruck.Id = 1;
                truck.Add(newTruck);
            }

            jsonString = JsonConvert.SerializeObject(truck);
            File.WriteAllText(FULLPATH, jsonString);
        }

        /// <summary>
        /// Gets collection of all <see cref="Truck"/> in json database.
        /// </summary>
        /// <returns>A collection of <see cref="Truck"/></returns>
        static public IEnumerable<Truck> GetAll()
        {
            var trucks = new List<Truck>();

            JsonTextReader reader = new JsonTextReader(new StreamReader(FULLPATH));
            reader.SupportMultipleContent = true;

            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }

                JsonSerializer serializer = new JsonSerializer();
                trucks.AddRange(serializer.Deserialize<Truck[]>(reader));
            }

            reader.Close();

            return trucks;
        }

        static public void Delete(int id)
        {
            string jsonString = "";
            var trucks = new List<Truck>();

            if (File.Exists(FULLPATH))
            {

                JsonTextReader reader = new JsonTextReader(new StreamReader(FULLPATH));
                reader.SupportMultipleContent = true;

                while (true)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    JsonSerializer serializer = new JsonSerializer();
                    trucks.AddRange(serializer.Deserialize<Truck[]>(reader));
                }

                var deletedTruck = trucks.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
                trucks.Remove(deletedTruck);

                foreach (var truck in trucks)
                {
                    if (truck.Id > id)
                    {
                        truck.Id--;
                    }
                }

                reader.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Can not to delete not existed object with ID = {id}");
            }

            jsonString = JsonConvert.SerializeObject(trucks);
            File.WriteAllText(FULLPATH, jsonString);
        }

        public static Truck GetById(int id) =>
            GetAll().Where(x => x.Id == id).Select(x => x).FirstOrDefault();

        static public void SortByFuel()
        {
            var trucks = GetAll().OrderBy(x => x.FuelConsumption).ToList();
            int counter = 1;
            foreach (var truck in trucks)
            {
                truck.Id = counter;
                counter++;
            }
            string jsonString = JsonConvert.SerializeObject(trucks);
            File.WriteAllText(FULLPATH, jsonString);
        }
        static public void Update(int id, Truck updatedTruck)
        {
            var truck = GetById(id);
            
            updatedTruck.Id = id;

            string jsonString = "";
            var trucks = new List<Truck>();

            if (File.Exists(FULLPATH))
            {

                JsonTextReader reader = new JsonTextReader(new StreamReader(FULLPATH));

                reader.SupportMultipleContent = true;

                while (true)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    JsonSerializer serializer = new JsonSerializer();
                    trucks.AddRange(serializer.Deserialize<Truck[]>(reader));

                    trucks[id - 1] = updatedTruck;
                }

                reader.Close();
            }

            jsonString = JsonConvert.SerializeObject(trucks);
            File.WriteAllText(FULLPATH, jsonString);

        }
    }
}
