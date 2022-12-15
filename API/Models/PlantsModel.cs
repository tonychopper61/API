using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class PlantsModel
    {
        public PlantsModel(Plants plants)
        {
            ID = plants.ID;
            Species = plants.Species;
            Price = (int)plants.Price;
            Image = plants.Image;
        }

        public int ID { get; set; }
        public string Species { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}