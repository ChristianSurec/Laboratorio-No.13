<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_No._13._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            Puesto<asp:DropDownList ID="DropDownListPuesto" runat="server" OnSelectedIndexChanged="DropDownListPuesto_SelectedIndexChanged">
                <asp:ListItem>Seleccione una opción</asp:ListItem>
                <asp:ListItem>Estudiante</asp:ListItem>
                <asp:ListItem>Profesor</asp:ListItem>
                <asp:ListItem>Personal Administrativo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Aceptar" runat="server" Height="37px" OnClick="Aceptar_Click" Text="Aceptar" Width="115px" />
            <br />
            Nombre&nbsp;
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
            <br />
            Apellido&nbsp;
            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
            <br />
            Dirección<asp:TextBox ID="TextBoxDireccion" runat="server" Height="16px"></asp:TextBox>
            <br />
            Fecha Nacimiento<br />
            <asp:Calendar ID="CalendarFechaNacimiento" runat="server" OnSelectionChanged="CalendarFechaNacimiento_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <br />
            Estudiante<br />
            Carné esudiante<asp:TextBox ID="TextBoxCarneEstudiante" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Profesor<br />
            ID Profesor<asp:TextBox ID="TextBoxIdProfesor" runat="server"></asp:TextBox>
            <br />
            Título Universitario<asp:TextBox ID="TextBoxTituloUniversitario" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Personal Administrativo<br />
            Numero de IGSS<asp:TextBox ID="TextBoxNumeroIGSS" runat="server"></asp:TextBox>
            <br />
            Profesión
            <asp:TextBox ID="TextBoxProfesion" runat="server"></asp:TextBox>
            <br />
            <br />
            Inicio de Labores<asp:Calendar ID="CalendarInicioLabores" runat="server"></asp:Calendar>
            <br />
            Fin de Labores<br />
            <asp:Calendar ID="CalendarFinLabores" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="ButtonElegir" runat="server" Height="47px" OnClick="ButtonElegir_Click" Text="Guardar Datos" Width="139px" />
            <br />
            <asp:Button ID="ButtonIngresarAlumno" runat="server" Height="33px" Text="Ingresar Alumno" Width="140px" OnClick="ButtonIngresarAlumno_Click" />
            <br />
            <asp:Button ID="ButtonIngresarProfesor" runat="server" Height="40px" Text="Ingresar Profesor" Width="148px" OnClick="ButtonIngresarProfesor_Click" />
            <br />
            <asp:Button ID="ButtonIngresarPersonal" runat="server" Height="43px" Text="Ingresar Personal" Width="164px" OnClick="ButtonIngresarPersonal_Click" />
            <br />
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
