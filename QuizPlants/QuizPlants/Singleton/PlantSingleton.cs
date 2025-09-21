using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuizPlants.Models;

namespace QuizPlants.Singleton
{
    public class PlantSingleton
    {
        static PlantsDBEntities db;

        public static PlantsDBEntities GetInstance()
        {
            if (db == null)
            {
                db = new PlantsDBEntities();
            }
            return db;
        }
    }
}