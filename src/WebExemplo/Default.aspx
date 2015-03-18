<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebExemplo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Arial Narrow', Arial, sans-serif;">
        <div style="padding: 10px; line-height: 30px; border: solid 2px #494949; border-radius: 5px; background-color: #e8e8e8;">

            <div style="text-align: center;">
                <h2>Consuming Webservice</h2>
            </div>

            <asp:TextBox ID="tbCodEmpresa1" runat="server" Width="80px">0</asp:TextBox>
            &nbsp;Código da empresa, para que tem contrato com o Correios.<br />

            <asp:TextBox ID="tbSenha1" runat="server" Width="80px">0</asp:TextBox>
            &nbsp;Senha - Utilizado junco com o contrato.<br />

            <asp:DropDownList ID="ddlServico1" runat="server">
                <asp:ListItem Selected="True" Value="41106">41106 - PAC sem contrato</asp:ListItem>
                <asp:ListItem Value="41068">41068 - PAC com contrato</asp:ListItem>
                <asp:ListItem Value="40010">40010 - SEDEX sem contrato</asp:ListItem>
                <asp:ListItem Value="40096">40096 - SEDEX com contrato</asp:ListItem>
                <asp:ListItem Value="40045">40045 - SEDEX a Cobrar, sem contrato</asp:ListItem>
                <asp:ListItem Value="40126">40126 - SEDEX a Cobrar, com contrato</asp:ListItem>
                <asp:ListItem Value="40215">40215 - SEDEX 10, sem contrato</asp:ListItem>
                <asp:ListItem Value="40290">40290 - SEDEX Hoje, sem contrato</asp:ListItem>
                <asp:ListItem Value="81019">81019 - e-SEDEX, com contrato</asp:ListItem>
            </asp:DropDownList>
            &nbsp;Tipo do serviço<br />

            <asp:TextBox ID="tbCepO1" runat="server" Width="80px">31000100</asp:TextBox>
            &nbsp;CEP Origem<br />

            <asp:TextBox ID="tbCepD1" runat="server" Width="80px">11000100</asp:TextBox>
            &nbsp;CEP Destino<br />

            <asp:TextBox ID="tbPeso1" runat="server" Width="80px">1</asp:TextBox>
            &nbsp;Peso em Kg<br />

            <asp:DropDownList ID="ddlFormato1" runat="server">
                <asp:ListItem Selected="True" Value="1">1 – Formato caixa/pacote</asp:ListItem>
                <asp:ListItem Value="2">2 – Formato rolo/prisma</asp:ListItem>
            </asp:DropDownList>
            &nbsp;Formato<br />

            <asp:TextBox ID="tbCompr1" runat="server" Width="33px">16</asp:TextBox>
            &nbsp;Comprimento (cm)&nbsp;&nbsp;
            
            <asp:TextBox ID="tbAltur1" runat="server" Width="33px">5</asp:TextBox>
            &nbsp;Altura (cm)&nbsp;&nbsp;
            
            <asp:TextBox ID="tbLarg1" runat="server" Width="33px">11</asp:TextBox>
            &nbsp;Largura(cm)&nbsp;&nbsp;
            
            <asp:TextBox ID="tbDiam1" runat="server" Width="33px">0</asp:TextBox>
            &nbsp;Diâmetro (cm)<br />

            <asp:DropDownList ID="ddlMaoP1" runat="server">
                <asp:ListItem Value="S">Mão própria SIM</asp:ListItem>
                <asp:ListItem Value="N" Selected="True">Mão própria NÃO</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlAvisoR1" runat="server">
                <asp:ListItem Value="S">Aviso de Recebimento SIM</asp:ListItem>
                <asp:ListItem Value="N" Selected="True">Aviso de Recebimento NÃO</asp:ListItem>
            </asp:DropDownList>
            <br />

            <asp:TextBox ID="tbValD1" runat="server" Width="80px">0</asp:TextBox>
            &nbsp;Valor declarado(R$)&nbsp; -&nbsp; 0 para não declarado

            <div style="padding-top: 20px; text-align: center;">
                <asp:Button ID="btnGetWS" runat="server" OnClick="btnGetWS_Click" Text="Get Webservices" Height="30px" />
            </div>

            <div style="line-height: 20px; background-color: #FFCC99; border-radius: 5px;">
                <div style="padding: 5px; margin: 5px;">
                    <div style="width: 100%; text-align: center; font-weight: bold;">Webservice Return</div>
                    <asp:Label ID="lblRes1" runat="server" Width="100%" Font-Size="15px"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
