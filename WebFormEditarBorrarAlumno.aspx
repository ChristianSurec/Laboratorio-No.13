<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormEditarBorrarAlumno.aspx.cs" Inherits="Laboratorio_No._13.WebFormEditarBorrarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Editar y Borrar Alumno</h1>
<p>
    Editar Datos de Alumno</p>
    <p>
        <asp:DropDownList ID="DropDownListEditarBorrar" runat="server">
            <asp:ListItem>Elija una opci&#243;n</asp:ListItem>
            <asp:ListItem>Editar Alumno</asp:ListItem>
            <asp:ListItem>Borrar Alumno</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
    Borrar Datos de Alumno</p>
    <p>
        <asp:Button ID="ButtonAceptar" runat="server" OnClick="ButtonAceptar_Click" Text="Aceptar" Width="157px" />
    </p>
<p>
    Carné Alumno<asp:TextBox ID="TextBoxCarneEditar" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonBuscarEditar" runat="server" OnClick="ButtonBuscarAlumno_Click" Text="Buscar Alumno" />
</p>
<p>
    Nombre<asp:TextBox ID="TextBoxNombreEditar" runat="server"></asp:TextBox>
</p>
<p>
    Apellido
    <asp:TextBox ID="TextBoxApellidoEditar" runat="server"></asp:TextBox>
</p>
<p>
    Dirección<asp:TextBox ID="TextBoxDireccionEditar" runat="server"></asp:TextBox>
</p>
<p>
    Fecha Nacimiento<asp:TextBox ID="TextBoxFechaNaEditar" runat="server" Width="125px"></asp:TextBox>
</p>
<asp:Calendar ID="CalendarEditar" runat="server"></asp:Calendar>
<p>
    <asp:Button ID="ButtonGuardarDatos" runat="server" Height="36px" Text="Guardar Cambios" Width="127px" OnClick="ButtonGuardarDatos_Click" />
</p>
<p>
    &nbsp;</p>
<p>
    Carné Alumno<asp:TextBox ID="TextBoxCarneBorrar" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonBuscarEliminar" runat="server" Text="Buscar Alumno" Width="124px" OnClick="ButtonBuscarEliminar_Click" />
</p>
<p>
    Nombre
    <asp:TextBox ID="TextBoxNombreBorrar" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    Apellido
    <asp:TextBox ID="TextBoxApellidoBorrar" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    Dirección<asp:TextBox ID="TextBoxDireccionBorrar" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    Fecha Nacimiento<asp:TextBox ID="TextBoxFechaNaBorrar" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonBorrarDatos" runat="server" Height="35px" Text="Borrar Datos" Width="149px" OnClick="ButtonBorrarDatos_Click" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
