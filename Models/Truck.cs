using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public double FuelConsumption { get; set; }

        public Truck(string name, int price, int speed, int capacity, double fuelConsumption)
        {
            this.Name = name;
            this.Price = price;
            this.Speed = speed;
            this.Capacity = capacity;
            this.FuelConsumption = fuelConsumption;
        }

        [JsonConstructor]
        public Truck(int id, string name, int price, int speed, int capacity, double fuelConsumption)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Speed = speed;
            this.Capacity = capacity;
            this.FuelConsumption = fuelConsumption;
        }

    }
}
