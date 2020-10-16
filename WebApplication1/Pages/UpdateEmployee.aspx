<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateEmployee.aspx.cs" Inherits="WebApplication1.Pages.UpdateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class="update-html">
<head>
    <title></title>
    <link rel="stylesheet" href="../content/css/updateemployee.css" type="text/css" />
</head>
<body class="update-body">
    <div class="update-main-div">
        <div class="update-header">
            <h2 class="update-header-content">Update Employee</h2>
        </div>
        <div class="update-content">
            <div class="update-sub-content-div">
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="EmpIDUpdateLabel" Text="Employee ID : " runat="server" class="update-lbl-one" />
                            </td>
                            <td>
                                <asp:TextBox ID="EmpIDUpdateTextBox" runat="server"  class="update-textbox-one" ReadOnly="true" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmpID" runat="server" 
                                        ForeColor="red" ErrorMessage="Employee ID is Required" ControlToValidate="EmpIDUpdateTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="FirstNameUpdateLabel" Text="First Name : " runat="server" class="update-lbl-two" />
                            </td>
                            <td>
                                <asp:TextBox ID="FirstNameUpdateTextBox" runat="server"  class="update-textbox-two" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" 
                                   ForeColor="red" ErrorMessage="First Name is Required" ControlToValidate="FirstNameUpdateTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="LastNameUpdateLabel" Text="Last Name : " runat="server" class="update-lbl-three" />
                            </td>
                            <td>
                                <asp:TextBox ID="LastNameUpdateTextBox" runat="server"  class="update-textbox-three" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                                    ForeColor="Red" ErrorMessage="Last Message is Required" ControlToValidate="LastNameUpdateTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="EmailIDUpdateLabel" Text="Email ID : " runat="server" class="update-lbl-four" />
                            </td>
                            <td>
                                <asp:TextBox ID="EmailIDUpdateTextBox" runat="server"  class="update-textbox-four" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmailID" runat="server"
                                    ForeColor="Red" ErrorMessage="Email ID is Required" ControlToValidate="EmailIDUpdateTextBox">
                                </asp:RequiredFieldValidator>
                        
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" 
                                    runat="server" ForeColor="Red"
                                    ErrorMessage="Invalid Email ID" ControlToValidate="EmailIDUpdateTextBox"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                </asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="PhoneNumberUpdateLabel" Text="Phone Number : " runat="server" class="update-lbl-five" />
                            </td>
                            <td>
                                <asp:TextBox ID="PhoneNumberUpdateTextBox" runat="server"  class="update-textbox-five" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhoneNumber" runat="server"
                                    ForeColor="Red" ErrorMessage="Phone Number is Required" 
                                    ControlToValidate="PhoneNumberUpdateTextBox">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhoneNumber" 
                                        runat="server" ForeColor="Red" placeholder="Phone Number"
                                        ErrorMessage="Invalid Phone Number" ControlToValidate="PhoneNumberUpdateTextBox"
                                        ValidationExpression="^([6-9]{1}[0-9]{9})$">
                                </asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-sub-content">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="DepartmentIDUpdateLabel" Text="Department ID : " runat="server" class="update-lbl-six" />
                            </td>
                            <td>
                                <asp:TextBox ID="DepartmentIDUpdateTextBox" runat="server"  class="update-textbox-six" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align:center">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDpartmentID" 
                                    runat="server" ForeColor="Red" 
                                    ErrorMessage="Department ID is Required" 
                                    ControlToValidate="DepartmentIDUpdateTextBox">
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="update-button-div">
                    <asp:Button ID="UpdateEmpButton" Text="Update Employee" runat="server" class="update-button" OnClick="updateEmployeeClick" />
                </div>
            </div>
        </div>
    </div>
</body>
</html>
</asp:Content>