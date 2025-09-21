using QuizPlants.Models;
using QuizPlants.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizPlants.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }

        }

        protected void refreshGrid()
        {
            List<Plant> plants = PlantRepository.GetAllPlants();
            PlantsGV.DataSource = plants;
            PlantsGV.DataBind();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertPage.aspx");
            refreshGrid();
        }

        protected void PlantsGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = PlantsGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text;
            PlantRepository.DeletePlant(id);
            refreshGrid();

        }

        protected void PlantsGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = PlantsGV.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            Response.Redirect("EditPage.aspx?id=" + id);
            refreshGrid();

        }
    }
}