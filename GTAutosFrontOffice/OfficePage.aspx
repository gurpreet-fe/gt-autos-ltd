<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OfficePage.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            OfficeCode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOfficeCode" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            AddressLine1&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddressLine1" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            AddressLine2&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddressLine2" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p>
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        </p>
        <p>
            PostCode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPostCode" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        </p>
        <p>
            PhoneNumber&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtPhoneNumber" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
        </p>
        <p>
            InspectionDate&nbsp;&nbsp;
            <asp:TextBox ID="txtInspectionDate" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="IsActive" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
&nbsp;IsActive</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" style="margin-bottom: 0px" Text="OK" Width="76px" />
&nbsp;<asp:Button ID="Button2" runat="server" Height="28px" OnClick="Button2_Click" Text="Cancel" Width="76px" />
        </p>
    </form>
</body>
</html>
