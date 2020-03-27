<script runat="server">

    Protected Sub lstCustomerList_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
</script>
<form id="form1" runat="server">
        <asp:ListBox ID="lstCustomerList" runat="server" Height="336px" Width="421px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
        </form>
