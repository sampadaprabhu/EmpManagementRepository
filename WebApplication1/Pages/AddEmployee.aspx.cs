using EmpManagementBL;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addEmployeeClick(object sender, EventArgs e)
        {
            if ((FirstNameTextBox.Text != "") && (LastNameTextBox.Text != "") &&
                (EmailIDTextBox.Text != "") && (PhoneNumberTextBox.Text != "") &&
                (DepartmentIDTextBox.Text != ""))
            {
                try
                {
                    EmpManagementModel empManagementModel = new EmpManagementModel();
                    empManagementModel.FirstName = FirstNameTextBox.Text;
                    empManagementModel.LastName = LastNameTextBox.Text;
                    empManagementModel.EmailID = EmailIDTextBox.Text;
                    empManagementModel.PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
                    empManagementModel.DepartmentID = Convert.ToInt32(DepartmentIDTextBox.Text);
                    IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
                    EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
                    empManagementService.AddEmployee(empManagementModel);
                    Response.Write("<script>alert('Data Added Successfully!!')</script>");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                Response.Write("<script>alert('All Fields Are Mandatory')</script>");
            }  
        }
    }
}