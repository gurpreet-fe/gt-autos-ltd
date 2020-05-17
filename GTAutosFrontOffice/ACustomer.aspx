<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 24px">
    <form id="form1" runat="server">
        <div>
            CustomerID
            <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="TxtCustomerID_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
            <br />
            First Name
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="TxtFirstName_TextChanged"></asp:TextBox>
            <br />
            Last Name
            <asp:TextBox ID="txtLastName" runat="server" OnTextChanged="TxtLastName_TextChanged"></asp:TextBox>
            <br />
            Phone Number 
            <asp:TextBox ID="txtPhoneNumber" runat="server" OnTextChanged="TxtPhoneNumber_TextChanged"></asp:TextBox>
            <br />
            Address
            <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="TxtAddress_TextChanged"></asp:TextBox>
            <br />
            Email Address
            <asp:TextBox ID="txtEmailAddress" runat="server" OnTextChanged="TxtEmailAddress_TextChanged"></asp:TextBox>
            <br />
            Date of Birth
            <asp:TextBox ID="txtDateOfBirth" runat="server" OnTextChanged="TxtDateOfBirth_TextChanged"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="TxtPassword_TextChanged"></asp:TextBox>
            <br />
            Postcode
            <asp:TextBox ID="txtPostcode" runat="server" OnTextChanged="TxtPostcode_TextChanged"></asp:TextBox>
            <br />
            <asp:CheckBox ID="OptInMarketingCompleted" runat="server" OnCheckedChanged="CheckBoxMarketing_CheckedChanged" />
            <br />
            <asp:CheckBox ID="ActiveCompleted" runat="server" OnCheckedChanged="CheckBoxActive_CheckedChanged" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" OnClick="BtnCancel_Click" Text="Cancel" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
         </div>
    </form>
</body>
</html>
