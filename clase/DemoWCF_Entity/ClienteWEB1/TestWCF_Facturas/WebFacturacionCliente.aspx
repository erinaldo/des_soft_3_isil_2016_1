<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WebFacturacionCliente.aspx.cs" Inherits="TestWCF_Facturas_WebFacturacionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p class="auto-style7">
        <strong>TEST DEL SERVICIO DE FACTURAS (CLIENTES-FECHA)</strong></p>
<table class="auto-style1">
    <tr>
        <td class="auto-style3">Seleccione Cliente:</td>
        <td class="auto-style5">
        <asp:DropDownList ID="cboCliente" runat="server" Height="25px" Width="223px">
        </asp:DropDownList>
        </td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style4">Ingrese Fecha de Inicio:</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtFecini" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecini" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Ingrese fecha de Fin:</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtFecfin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFecfin" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            <asp:CheckBox ID="chkLINQ" runat="server" Text="Con LINQ?" Width="200px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="3">
            <asp:GridView ID="grvFacturas" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="#333333" GridLines="None" Width="978px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Num_fac" HeaderText="Nro. Factura" />
                    <asp:BoundField DataField="Fec_fac" DataFormatString="{0:d}" HeaderText="Fec. Factura" />
                    <asp:BoundField DataField="Fec_can" DataFormatString="{0:d}" HeaderText="Fec. Cancelación" />
                    <asp:BoundField DataField="Total" DataFormatString="{0:n}" HeaderText="Total (S/.)" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;Su deuda actual es:&nbsp;</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtDeuda" runat="server" ReadOnly="True" Width="178px"></asp:TextBox>
        </td>
    </tr>
</table>

</asp:Content>

