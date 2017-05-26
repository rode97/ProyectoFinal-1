<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proyecto_final2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Cargar Datos Comunidad" OnClick="Button1_Click" />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cargar Datos Propietario" />
        <asp:GridView ID="GridView3" runat="server">
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar Datos Garage" />
        <asp:GridView ID="GridView4" runat="server">
        </asp:GridView>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Mostrar Datos Gastos" />
        <asp:GridView ID="GridView5" runat="server">
        </asp:GridView>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mostrar datos del local" />
        <asp:GridView ID="GridView6" runat="server">
        </asp:GridView>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Mostrar datos de pago" />
        <asp:GridView ID="GridView7" runat="server">
        </asp:GridView>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Datos de piso" />
        <asp:GridView ID="GridView8" runat="server">
        </asp:GridView>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Mostrar datos de propiedad" />
    </div>

    </asp:Content>
