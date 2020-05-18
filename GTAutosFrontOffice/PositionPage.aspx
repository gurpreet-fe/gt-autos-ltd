<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PositionPage.aspx.vb" Inherits="PositionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Position&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxPositionId" runat="server" OnTextChanged="TxtPositionId_Changed"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnFind" runat="server" Text="Find" OnClick="BtnFind_Click" Height="25px" Width="80px"/>
            <br />
            <br />
            Position Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbPositionName" runat="server" OnTextChanged="TxtPositionName_Changed"></asp:TextBox>
            <br />
            Description&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbDescription" runat="server" OnTextChanged="TbDescription_Changed" Height="122px" Width="236px"></asp:TextBox>
            <br />
            Salary&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TxtSalary" runat="server" OnTextChanged="TxtSalary_Changed"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" Height="25px" Width="80px"/>
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" Height="25px" Width="80px" />
            <asp:Button ID="BtnList" runat="server" Text="List" OnClick="BtnList_Click" Height="25px" Width="80px"/>
        </div>
    </form>
</body>
</html>
