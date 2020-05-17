<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you would like to delete your account?<br />
            <asp:Button ID="btnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="BtnNo_Click" Text="No" Width="37px" />
        </div>
    </form>
</body>
</html>
