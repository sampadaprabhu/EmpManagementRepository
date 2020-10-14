<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="WebApplication1.Pages.AddEmployee" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<!DOCTYPE html>

<html class="add-html">
<%--<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/CSS/AddEmployee.css" type="text/css" />
</head>--%>
<body class="add-body">
    <%--<form id="form1" runat="server" class="add-form">--%>
        <div class="add-form-div" style="height:727px;">
            <div class="add-header">
                <h2 class="add-header-content">Add New Employee</h2>
            </div>
            <div class="add-content">
                <div class="add-sub-content-div">
                    <div class="add-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="FirstNameLabel" Text="First Name : " runat="server" class="add-lbl-one" />
                            </td>    
                            <td>     
                                <asp:TextBox ID="FirstNameTextBox" runat="server"  class="add-textbox-one"/>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                           <td style="text-align:center">     
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" 
                                   ForeColor="red" ErrorMessage="First Name is Required" ControlToValidate="FirstNameTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>       
                </div>
                <div class="add-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" Text="Last Name : " runat="server" class="add-lbl-two" />
                            </td>
                            <td>
                                <asp:TextBox ID="LastNameTextBox" runat="server"  class="add-textbox-two"/>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                                    ForeColor="Red" ErrorMessage="Last Message is Required" ControlToValidate="LastNameTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="add-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="EmailIDLabel" Text="Email-ID : " runat="server" class="add-lbl-three" />
                            </td>
                            <td>
                                <asp:TextBox ID="EmailIDTextBox" runat="server" class="add-textbox-three"/>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmailID" runat="server"
                                    ForeColor="Red" ErrorMessage="Email ID is Required" ControlToValidate="EmailIDTextBox">
                                </asp:RequiredFieldValidator>
                        
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" 
                                    runat="server" ForeColor="Red"
                                    ErrorMessage="Invalid Email ID" ControlToValidate="EmailIDTextBox"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                </asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="add-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="PhoneNumberLabel" Text="Phone Number : " runat="server" class="add-lbl-four" />
                            </td>
                            <td>
                                <asp:TextBox ID="PhoneNumberTextBox" runat="server"  class="add-textbox-four"/>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhoneNumber" runat="server"
                                    ForeColor="Red" ErrorMessage="Phone Number is Required" ControlToValidate="PhoneNumberTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="add-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="DepartmentIDLabel" Text="Department ID : " runat="server" class="add-lbl-five" />
                            </td>
                            <td>
                                <asp:TextBox ID="DepartmentIDTextBox" runat="server"  class="add-textbox-five"/>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDpartmentID" runat="server"
                                    ForeColor="Red" ErrorMessage="Department ID is Required" ControlToValidate="DepartmentIDTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                    
                    
                </div>
                <div class="add-btn-div">
                    <asp:Button ID="AddEmployeeButton" Text="ADD EMPLOYEE" runat="server" class="add-button" OnClick="addEmployeeClick" />
                </div>
                </div>
            </div>
        </div>
    <%--</form>--%>
</body>
</html>
</asp:Content>