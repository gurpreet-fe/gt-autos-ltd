<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 24px">
    <form id="form1" runat="server">
        <div>
            OrderID
            <asp:TextBox ID="TxtOrderID" runat="server" OnTextChanged="TxtOrderID_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            CustomerID <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="TxtCustomerID_TextChanged"></asp:TextBox>
            <br />
            Car
            <asp:TextBox ID="txtCar" runat="server" OnTextChanged="txtCar_TextChanged"></asp:TextBox>
            <asp:DropDownList ID="DropDownCars" runat="server" OnSelectedIndexChanged="DropDownCars_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            Payment
            <asp:TextBox ID="TxtPaymentID" runat="server"></asp:TextBox>
            <br />
            Date of order
            <asp:TextBox ID="TxtDateOfOrder" runat="server" OnTextChanged="TxtDateOfOrder_TextChanged"></asp:TextBox>
            <br />
            Services
            <asp:DropDownList ID="DropDownServices" runat="server" OnSelectedIndexChanged ="DropDownServices_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            Price
            <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="txtPrice_TextChanged"></asp:TextBox>
            <br />
            Order status
            <asp:TextBox ID="txtOrderStatus" runat="server" OnTextChanged="txtOrderStatus_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="CheckBoxCompleted" runat="server" OnCheckedChanged="CheckBoxCompleted_CheckedChanged" Text="  Completed" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
