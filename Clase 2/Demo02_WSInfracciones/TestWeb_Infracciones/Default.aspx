<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" >
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Ingresa la placa:
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    ....
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                </asp:TableCell>
                
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Multa:
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:Label ID="lblMulta" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Propietario:
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:Label ID="lblPropietario" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>
    
    </div>
        
        
        
        
        
        
        
    </form>
</body>
</html>
