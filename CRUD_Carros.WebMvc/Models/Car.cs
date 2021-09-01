using System;

namespace CRUD_Carros.WebMvc.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public Car(string model, DateTime year, string color, string brand)
        {
            Model = model;
            Year = year;
            Color = color;
            Brand = brand;
        }
    }
}
