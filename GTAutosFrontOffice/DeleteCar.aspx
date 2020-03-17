<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCar.aspx.cs" Inherits="DeleteCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="BtnYes" runat="server" Text="Yes" OnClick="BtnYes_Click" />
            <asp:Button ID="BtnNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
