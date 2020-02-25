<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPage.aspx.cs" Inherits="StaffPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff<br />
            <br />
            Name<asp:TextBox ID="TxtStaffName" runat="server"></asp:TextBox>
            <br />
            Office Code<asp:TextBox ID="TxtOfficeCode" runat="server"></asp:TextBox>
            <br />
            Position Id<asp:TextBox ID="TxtPositionId" runat="server"></asp:TextBox>
            <br />
            Contanct Number<asp:TextBox ID="TxtStaffContactNumber" runat="server"></asp:TextBox>
            <br />
            Address<asp:TextBox ID="TxtStaffAddress" runat="server"></asp:TextBox>
            <br />
            Hire Date<asp:Calendar ID="TxtHireDate" runat="server"></asp:Calendar>
            <br />
            <asp:CheckBox ID="CBIsEmployed" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            Employed<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
