using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contractor
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)  //only runs this code block if we are not posting back
            {
                previousCalendar.SelectedDate = DateTime.Today;
                startCalendar.SelectedDate = DateTime.Today.AddDays(14);
                endCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }
        }

        protected void previousCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void startCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void endCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            string employeeName = nameTextBox.Text;
            string assignmentName = assignmentTextBox.Text;
            int assignmentCost = Math.Abs(startCalendar.SelectedDate.Subtract(endCalendar.SelectedDate).Days) * 500;
            int restTime = Math.Abs(previousCalendar.SelectedDate.Subtract(startCalendar.SelectedDate).Days);

            if (Math.Abs(startCalendar.SelectedDate.Subtract(endCalendar.SelectedDate).Days) > 21)
            {
               assignmentCost += 1000;
            }


            if (restTime < 14 )
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
            }
            else
            {
                resultLabel.Text = "Assignment of " + employeeName + " to Project: " + assignmentName + 
                    String.Format(" is authorized. Budget total: {0:C}", assignmentCost);
            }


        }
    }
}