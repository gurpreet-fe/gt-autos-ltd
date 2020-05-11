<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OfficeList.aspx.cs" Inherits="OfficeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOfficeList" runat="server" Height="336px" Width="421px" OnSelectedIndexChanged="lstOfficeList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Add" Width="76px" />
&nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="76px" Height="29px" />
&nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="76px" Height="29px" />
        </p>
        <p>
            Filter by PostCode
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnApply" runat="server" Height="29px" OnClick="Button2_Click" Text="Apply" Width="76px" />
&nbsp;<asp:Button ID="BtnClear" runat="server" Height="29px" OnClick="BtnClear_Click" Text="Clear" Width="76px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
