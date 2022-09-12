<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1" style="margin-top: 30px;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Roll No:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtNo" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Student Name :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtName" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Course Name: </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddl_Course" runat="server" Height="40px" Width="280px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Class Name:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddl_class" runat="server" Height="40px" Width="280px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">E-mail:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtEmail" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtMobile" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date Of Birth:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtDob" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="Btn_Add" runat="server" Font-Bold="True" Font-Size="15pt" Text="Add Class" Style="padding: 10px;" Width="200px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:GridView ID="GridView1" align="center" runat="server" Width="647px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
