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
        //public var EmpID;
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
        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string emp = GridView.DataKeys[e.RowIndex].Values["EmpID"].ToString();
            IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
            EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
            empManagementService.DeleteEmployee(emp);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
        }

        protected void lblEdit_Click(object sender, EventArgs e)
        {
            
            //Response.Redirect("~/UpdateEmployee.aspx?EmpID=" + this.EmpID);
            //string url = "UpdateEmployee.aspx";
            //string s = "window.open('" + url + "', 'popup_window', 'width=300,height=600,left=600,top=600,resizable=yes,scrollable=yes');";
            //ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }

        protected void lblDelete_Click(object sender, EventArgs e)
        {
            //string emp = GridView.DataKeys[e.RowIndex].Values["EmpID"].ToString();
            LinkButton lnk = sender as LinkButton;
            GridViewRow gridrow = lnk.NamingContainer as GridViewRow;
            string emp = GridView.DataKeys[gridrow.RowIndex].Values["EmpID"].ToString();
            IEmpManagementRepository empManagementRepository = new EmpManagementRepository();
            EmpManagementService empManagementService = new EmpManagementService(empManagementRepository);
            empManagementService.DeleteEmployee(emp);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string emp = GridView.DataKeys[index].Values["EmpID"].ToString();
                
                //GridViewRow row = GridView.Rows[index];
                //this.EmpID = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect("~/Pages/UpdateEmployee.aspx?EmpID=" + emp);
                //   Response.Redirect("~/UpdateEmployee.aspx?EmpID=" + row.Cells[0].Text);
            }
        }
    }
}