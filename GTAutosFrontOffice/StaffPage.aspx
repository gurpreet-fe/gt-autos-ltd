<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPage.aspx.cs" Inherits="StaffPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbStaffID" runat="server" OnTextChanged="TxtStaffID_Changed" Height="30px" Width="90px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnFind" runat="server" Text="Find" OnClick="BtnFind_Click" Height="30px" Width="90px"/>
            <br />
            <br />
            Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TbStaffName" runat="server" OnTextChanged="TxtStaffName_Changed"></asp:TextBox>
            <br />
            Office Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbOfficeCode" runat="server" OnTextChanged="TxtOfficeCode_Changed" ></asp:TextBox>
            <br />
            Position ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TbPositionID" runat="server" OnTextChanged="TxtPositionID_Changed"></asp:TextBox>
            <br />
            Contact Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TbContactNumber" runat="server" OnTextChanged="TxtContactNumber_Changed"></asp:TextBox>
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TbAddress" runat="server" OnTextChanged="TxtAddress_Changed"></asp:TextBox>
            <br />
            Hire Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
            <asp:TextBox ID="TbHireDate" runat="server" OnTextChanged="TxtHireDate_Changed"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CbIsEmployed" runat="server" OnCheckedChanged="CbIsEmployed_CheckedChanged" />
            Employed<br />
            <br />
            <asp:Label ID="LblError" runat="server" Text="Error"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" Height="30px" Width="80px"/>
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" Height="30px" Width="80px" />
            <asp:Button ID="BtnList" runat="server" Text="List" OnClick="BtnList_Click" Height="30px" Width="80px"/>
        </div>
    </form>
</body>
</html>
