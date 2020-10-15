<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListOfEmployees.aspx.cs" Inherits="WebApplication1.Pages.ListOfEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class="table-html">
<%--<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/CSS/ListOfEmployees.css" type="text/css" />
</head>--%>

<body class="table-body">
    <%--<form id="form1" runat="server" class="table-form">--%>
        <div class="tbl-form-div">
            <%--<div class="header-tbl">
                <h2 class="tbl-header-content">List Of Employees</h2>
            </div>--%>
            <div class="table-data">
                <asp:GridView ID="GridView" class="gridView" runat="server" 
                    OnRowEditing="GridView_RowEditing" 
                    OnRowUpdating="GridView_RowUpdating" 
                    DataKeyNames="EmpID" OnRowDeleting="GridView_RowDeleting" 
                    AutoGenerateColumns="false" ForeColor="#333333" 
                    GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    <Columns>
                        <asp:TemplateField HeaderText ="EmpID"  ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lblEmpId" runat ="server" 
                                         Text ='<%# Eval("EmpID") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText ="First Name" ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lblfname" runat ="server" 
                                         Text ='<%# Eval("FirstName") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText ="Last Name" ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lbllname" runat ="server" 
                                         Text ='<%# Eval("LastName") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText ="Email ID" ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lblemailid" runat ="server" 
                                         Text ='<%# Eval("EmailID") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText ="Phone Number" ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lblphoneno" runat ="server" 
                                         Text ='<%# Eval("PhoneNumber") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText ="Department ID" ItemStyle-HorizontalAlign="Center">
                                 <ItemTemplate>
                                     <asp:Label ID="lbldeptno" runat ="server" 
                                         Text ='<%# Eval("DepartmentID") %>'></asp:Label>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:LinkButton ID="lblEdit" runat="server"
                                           OnClick="lblEdit_Click"
                                      ><img src="../images/edit.svg" /></asp:LinkButton>
                                 </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lblDelete" runat="server" OnClientClick="return confirm('Are you sure to delete?')"
                                     OnClick="lblDelete_Click">
                                    <img src="../images/delete.svg">
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%--<asp:commandfield showdeletebutton="true" />--%>
                    </Columns>
                </asp:GridView>
                
            </div>
        </div>
    <%--</form>--%>
</body>
</html>

</asp:Content>