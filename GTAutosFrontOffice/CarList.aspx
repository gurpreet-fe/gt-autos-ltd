<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarList.aspx.cs" Inherits="CarList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCarList" runat="server" Height="480px" Width="562px"></asp:ListBox>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
