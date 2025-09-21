using QuizPlants.Models;
using QuizPlants.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace QuizPlants.Repository
{
    public class PlantRepository
    {
        static PlantsDBEntities db = PlantSingleton.GetInstance();

        public static List<Plant> GetAllPlants()
        {
            return db.Plants.ToList();
        }

        public static Plant GetPlantById(string id)
        {
            return db.Plants.Find(id);
        }

        public static Plant GetPlantByName(string name)
        {
            return db.Plants.Where(x => x.PlantName == name).FirstOrDefault();
        }

        public static bool isUniquePlant(string name)
        {
            // Cek apakah nama plant sudah ada di database
            Plant plant = GetPlantByName(name);
            if (plant == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isCorrectOriginFormat(string origin)
        {
            // cek apakah format origin sesuai degan Regex
            string pattern = @"^[a-zA-Z\s]+, [a-zA-Z\s]+$";
            return Regex.IsMatch(origin, pattern);
        }

        public static string generateNewID()
        {
            string newID = "";
            Plant lastPlant = db.Plants.OrderByDescending(x => x.PlantId).FirstOrDefault();
            if (lastPlant == null)
            {
                newID = "PL001";
            }
            else
            {
                int lastID = int.Parse(lastPlant.PlantId.Substring(2));
                lastID++;
                newID = String.Format("PL{0:000}", lastID);
            }
            return newID;
        }

        public static void InsertPlant(string id, string name, string type, string origin)
        {
            Plant plant = new Plant();
            plant.PlantId = id;
            plant.PlantName = name;
            plant.PlantType = type;
            plant.PlantOrigin = origin;
            db.Plants.Add(plant);
            db.SaveChanges();
        }

        public static void DeletePlant(string id)
        {
            Plant plant = GetPlantById(id);
            db.Plants.Remove(plant);
            db.SaveChanges();
        }

        public static void EditPlant(string id, string name, string type, string origin)
        {
            Plant plant = GetPlantById(id);
            plant.PlantName = name;
            plant.PlantType = type;
            plant.PlantOrigin = origin;
            db.SaveChanges();
        }
    }
}