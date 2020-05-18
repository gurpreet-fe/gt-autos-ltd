<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StaffList.aspx.vb" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="LbStaffList" runat="server" Height="340px" Width="430px" OnSelectedIndexChanged="LbStaffList_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="BtnAdd" runat="server" Text="Add" Height="25px" Width="50px" OnClick="BtnAdd_Click"/>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEdit" runat="server" Text="Edit" Height="25px" Width="50px" OnClick="BtnEdit_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnDelete" runat="server" Text="Delete" Height="25px" Width="50px" OnClick="BtnDelete_Click" />
            <br />
            <br />
            Filter by Staff Contact Number:
            <asp:TextBox ID="TextBox1" runat="server" Width="203px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnApply" runat="server" Text="Apply" Height="25px" Width="50px" OnClick="BtnApply_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnClear" runat="server" Text="Clear" Height="25px" Width="50px" OnClick="BtnClear_Click"/>
            <br />
            <br />
            <asp:Label ID="LblError" runat="server" Text="LblError"></asp:Label>
        </div>
    </form>
</body>
</html>
