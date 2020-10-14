<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="WebApplication1.Pages.DeleteEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class="delete-html">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/CSS/DeleteEmployee.css" type="text/css" />
</head>
<body class="delete-body">
    <form id="form1" runat="server" class="delete-form">
        <div class="formform">
            <div class="headers">
                <h2 class="delete-header">Delete Employee</h2>
            </div>
            <div class="contents">
                <div class="dlt-sub-content-div">
                    <div class="sub-contents">
                    <asp:Label ID="label1" Text="Employee ID : " runat="server" class="dlt-lbl-one" />
                    <asp:TextBox ID="EmpDltTextBox" runat="server"  class="delete-textbox" />
                </div>
                <div class="delete-button-div">
                    <asp:Button ID="button1" Text="DELETE EMPLOYEE" runat="server" class="delete-button" OnClick="deleteEmpClick" />
                </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
