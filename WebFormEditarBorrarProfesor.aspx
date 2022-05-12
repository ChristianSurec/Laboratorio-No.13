<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormEditarBorrarProfesor.aspx.cs" Inherits="Laboratorio_No._13.WebFormEditarBorrarProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Editar y Borrar Profesor</h1>
    <p>
        <asp:DropDownList ID="DropDownListEdtiarBorrar" runat="server">
            <asp:ListItem>Elija una opción</asp:ListItem>
            <asp:ListItem>Editar Datos</asp:ListItem>
            <asp:ListItem>Borrar Datos</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Editar Datos de Profesor</p>
    <p>
        <asp:Button ID="ButtonElegir" runat="server" OnClick="ButtonElegir_Click" Text="Aceptar" Width="106px" />
    </p>
    <p>
        Id profesor</p>
    <p>
        <asp:TextBox ID="TextBoxIdProfesorEditar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarEditar" runat="server" OnClick="ButtonBuscarEditar_Click" Text="Buscar" />
    </p>
    <p>
        Nombre<asp:TextBox ID="TextBoxEditarNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido<asp:TextBox ID="TextBoxEditarApellido" runat="server"></asp:TextBox>
    </p>
    <p>
        Dirección<asp:TextBox ID="TextBoxEditarDireccion" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Nacimiento<asp:TextBox ID="TextBoxEditarFechaNaEditar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        Titulo Universitario<asp:TextBox ID="TextBoxEditarTitulo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonEditar" runat="server" Height="26px" OnClick="ButtonEditar_Click" Text="ButtonGuardarDatos" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        BorrarDatos</p>
    <p>
        Id Profesor<asp:TextBox ID="TextBoxIdProfesorBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarBorrar" runat="server" OnClick="ButtonBuscarBorrar_Click" Text="Buscar" />
    </p>
    <p>
        Nombre<asp:TextBox ID="TextBoxNombreBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido<asp:TextBox ID="TextBoxApellidoBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        Dirección<asp:TextBox ID="TextBoxDireccionBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Naciminento<asp:TextBox ID="TextBoxFechaNaBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        Titulo Universitario<asp:TextBox ID="TextBoxTituloBorrar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBorrar" runat="server" OnClick="ButtonBorrar_Click" Text="Borrar" />
    </p>
</asp:Content>
