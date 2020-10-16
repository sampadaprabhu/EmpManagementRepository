using EmpManagementBL;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class ListOfEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
                EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
                DataSet dataSet = new DataSet();
                dataSet = empManagementService.GetAllEmployee();
                GridView.DataSource = dataSet;
                GridView.DataBind();
            }
        }

        protected void lblDelete_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton lnk = sender as LinkButton;
                GridViewRow gridrow = lnk.NamingContainer as GridViewRow;
                string emp = GridView.DataKeys[gridrow.RowIndex].Values["EmpID"].ToString();
                IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
                EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
                empManagementService.DeleteEmployee(emp);
                Page.Response.Redirect(Page.Request.Url.ToString(), false);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string emp = GridView.DataKeys[index].Values["EmpID"].ToString();
                Response.Redirect("~/Pages/UpdateEmployee.aspx?EmpID=" + emp);
            }
        }
    }
}