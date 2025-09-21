using QuizPlants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizPlants.Factory
{
    public class PlantFactory
    {
        public static Plant CreateNewPlant(string id, string name, string type, string origin)
        {
            Plant plant = new Plant();
            plant.PlantId = id;
            plant.PlantName = name;
            plant.PlantType = type;
            plant.PlantOrigin = origin;

            return plant;
        }
    }
}