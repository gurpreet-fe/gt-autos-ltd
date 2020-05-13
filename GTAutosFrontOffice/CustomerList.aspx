<%@Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="409px" Width="552px"></asp:ListBox>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <br />
        <br />
        Enter a CustomerID&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server" Height="17px" style="margin-top: 0px"></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
