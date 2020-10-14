using EmpManagementBL;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deleteEmpClick(object sender, EventArgs e)
        {
            if (EmpDltTextBox.Text!="")
            {
                    EmpManagementModel empManagementModel = new EmpManagementModel();
                IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
                EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
                    empManagementModel.EmpID = Convert.ToInt32(EmpDltTextBox.Text);
                    //empManagementService.DeleteEmployee(empManagementModel.EmpID);
                    Response.Write("<script>alert('Record Deleted Successfully!!')</script>");
            }
            else
            {
                Response.Write("<script>alert('All Fields Are Mandatory')</script>");
            }
        }
    }
}