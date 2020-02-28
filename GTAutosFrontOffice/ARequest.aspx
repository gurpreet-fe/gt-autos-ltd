<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARequest.aspx.cs" Inherits="ARequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Request ID<asp:TextBox ID="txtRequestID" runat="server" style="margin-left: 98px"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Height="23px" OnClick="Button3_Click" style="margin-left: 28px; margin-top: 1px" Text="Find" />
        </p>
        <p>
        Name<asp:TextBox ID="txtName" runat="server" style="margin-left: 129px"></asp:TextBox>
        </p>
    <p>
        Phone Number<asp:TextBox ID="txtPhoneNum" runat="server" style="margin-left: 74px"></asp:TextBox>
        </p>
    <p>
        Email Address<asp:TextBox ID="txtEmail" runat="server" style="margin-left: 78px"></asp:TextBox>
        </p>
    <p>
        Address<asp:TextBox ID="txtAddress" runat="server" style="margin-left: 114px"></asp:TextBox>
        </p>
    <p>
        Number Plate<asp:TextBox ID="txtNumberPlate" runat="server" style="margin-left: 82px"></asp:TextBox>
        </p>
    <p>
        Make
        <asp:TextBox ID="txtMake" runat="server" style="margin-left: 127px"></asp:TextBox>
    </p>
    <p>
        Model<asp:TextBox ID="txtModel" runat="server" style="margin-left: 126px"></asp:TextBox>
        </p>
    <p>
        Colour<asp:TextBox ID="txtColour" runat="server" style="margin-left: 124px"></asp:TextBox>
        </p>
    <p>
        Description<asp:TextBox ID="txtDescription" runat="server" style="margin-left: 95px"></asp:TextBox>
        </p>
    <p>
        Price
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 129px"></asp:TextBox>
    </p>
        <p>
            Date of Request<asp:TextBox ID="txtDateOfRequest" runat="server" style="margin-left: 65px"></asp:TextBox>
    </p>
        <p>
            Date of Purchase<asp:TextBox ID="txtDateOfPurchased" runat="server" style="margin-left: 57px"></asp:TextBox>
    </p>
        <p>
            Purhcased<asp:TextBox ID="txtPurchased" runat="server" style="margin-left: 96px"></asp:TextBox>
    </p>
        <p>
            Request<asp:TextBox ID="txtRequest" runat="server" style="margin-left: 109px"></asp:TextBox>
    </p>
        <asp:CheckBox ID="Active" runat="server" OnCheckedChanged="Active_CheckedChanged" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" />
    </form>
    </body>
</html>
