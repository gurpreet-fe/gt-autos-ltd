<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="306px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" Width="997px"></asp:ListBox>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
        <br />
        Enter order status&nbsp;&nbsp; <asp:TextBox ID="txtOrderStatus" runat="server" style="margin-bottom: 4px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply" />
        <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
&nbsp;<br />
        <br />
&nbsp;Enter OrderID&nbsp;
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnApply2" runat="server" OnClick="BtnApply2_Click" Text="Apply" />
        <asp:Button ID="BtnClear2" runat="server" OnClick="BtnClear2_Click" Text="Clear" />
        <br />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
