using System;
using EmpManagementBL;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateEmployeeClick(object sender, EventArgs e)
        {
            if ((EmpIDUpdateTextBox.Text != "") && (FirstNameUpdateTextBox.Text != "") &&
                (LastNameUpdateTextBox.Text != "") && (EmailIDUpdateTextBox.Text != "") &&
                (PhoneNumberUpdateTextBox.Text != "") && (DepartmentIDUpdateTextBox.Text != ""))
            {
                EmpManagementModel empManagementModel = new EmpManagementModel();
                IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
                EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
                empManagementModel.EmpID = Convert.ToInt32(EmpIDUpdateTextBox.Text);
                empManagementModel.FirstName = FirstNameUpdateTextBox.Text;
                empManagementModel.LastName = LastNameUpdateTextBox.Text;
                empManagementModel.EmailID = EmailIDUpdateTextBox.Text;
                empManagementModel.PhoneNumber = Convert.ToInt32(PhoneNumberUpdateTextBox.Text);
                empManagementModel.DepartmentID = Convert.ToInt32(DepartmentIDUpdateTextBox.Text);
                empManagementService.UpdateEmployee(empManagementModel);
                Response.Redirect("ListOfEmployees.aspx");
            }
            else
            {
                Response.Write("<script>alert('All Fields Are Mandatory')</script>");
            }
        }
    }
}