<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Work_01.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2>Employee</h2>
            <tr>
                <td>Id</td>
                <td><asp:TextBox runat="server" ID="idTextBox"></asp:TextBox></td>
            </tr>

              <tr>
                <td>Name</td>
                <td><asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox></td>
            </tr>

              <tr>
                <td>Email</td>
                <td><asp:TextBox runat="server" ID="emailTextBox"></asp:TextBox></td>
            </tr>

             <tr>
                <td><asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /></td>
                <td><asp:Button ID="retrieveButton" runat="server" Text="Retrieve" OnClick="retrieveButton_Click" /></td>
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
