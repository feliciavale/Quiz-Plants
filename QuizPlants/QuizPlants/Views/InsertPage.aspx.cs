using QuizPlants.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizPlants.Views
{
    public partial class InsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            // Buat variabel untuk id plant baru 
            string id = PlantRepository.generateNewID();

            // tampung input user
            string name = NameTb.Text;
            string type = TypeDDL.SelectedValue;
            string origin = OriginTb.Text;


            // Logic Validate
            // cek apakah ada textbox yang kosong
            if (name == "" || origin == "")
            {
                ErrorMsg.Text = "Please fill all the fields";
            }
            // cek apakah panjang nama plant sesuai ketentuan
            else if (name.Length < 5 || name.Length > 30)
            {
                ErrorMsg.Text = "Plant name must be 5-30 characters";
            }
            // cek apakah nama plant ada di database, function isUniquePlant() liat di repo
            else if (PlantRepository.isUniquePlant(name) == false)
            {
                ErrorMsg.Text = "Plant name already exist";
            }
            // cek apakah origin sesuai format, function isCorrectOriginFormat() liat di repo
            else if (PlantRepository.isCorrectOriginFormat(origin) == false)
            {
                ErrorMsg.Text = "Origin format must be City, Country";
            }
            // kalau aman semua, insert data ke database
            else
            {
                // Insert data ke database function InsertPlant() liat di repo
                PlantRepository.InsertPlant(id, name, type, origin);
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}