<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="assignment_2_project_ase.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <table>
        <tr>
            <td>enter username</td>
            <td>
                <asp:TextBox ID="user" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>enter password</td>
            <td>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td colspan = "2" align ="center">
            <asp:Button ID="loginbtn" runat="server" Text="log in" OnClick="loginbtn_Click" />
        </td>
        <td colspan = "2" align ="center">
            <asp:Button ID="clearbtn" runat="server" Text="clear" OnClick="clearbtn_Click" />
        </td>
    </table>
    </div>
    </form>
</body>
</html>
