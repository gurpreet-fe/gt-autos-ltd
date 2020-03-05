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
            Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtStaffName" runat="server"></asp:TextBox>
            <br />
            Office Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtOfficeCode" runat="server"></asp:TextBox>
            <br />
            Position Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtPositionId" runat="server"></asp:TextBox>
            <br />
            Contanct Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtStaffContactNumber" runat="server"></asp:TextBox>
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtStaffAddress" runat="server"></asp:TextBox>
            <br />
            Hire Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtHireDate" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CBIsEmployed" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            Employed<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
