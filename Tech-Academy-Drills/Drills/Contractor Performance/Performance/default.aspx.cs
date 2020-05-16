using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Performance
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //creates the array for project in view state
                double[] Projects = new double[0];
                ViewState.Add("Projects", Projects);

                //creates the array for rating in view state
                double[] Rating = new double[0];
                ViewState.Add("Rating", Rating);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //pull user input and set variables
            string newContractor = nameBox.Text;
            double newProjects = Convert.ToDouble(projectBox.Text);
            double newRating = Convert.ToDouble(ratingBox.Text);

            //pull project array from view state and extend the array
            double[] project = (double[])ViewState["Projects"];
            Array.Resize(ref project, project.Length + 1);

            //add newest user value to project array and store back in view state
            int newest = project.GetUpperBound(0);
            project[newest] = newProjects;
            ViewState["Projects"] = project;

            //pull rating array from view state and extend the array
            double[] rating = (double[])ViewState["Rating"];
            Array.Resize(ref rating, rating.Length + 1);

            //add newest user value to rating array and store back in view state
            int newest2 = rating.GetUpperBound(0);
            rating[newest2] = newRating;
            ViewState["Rating"] = rating;

            resultLabel.Text = String.Format("Total Projects Completed: {0}" +
                "<br />Average Rating per Contactor: {1:N2}<br />(Last Contractor Added: {2})",
               project.Sum(), rating.Average(), newContractor);

            //Resets user input text boxes after returning reslts
            nameBox.Text = "";
            projectBox.Text = "";
           ratingBox.Text = "";

        }
    }
}