using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_No._13
{
    public partial class _Default : Page
    {
        static List<Puesto> puestos = new List<Puesto>();
        static List<Alumno> alumnos = new List<Alumno>();
        static List<Profesor> profesores = new List<Profesor>();
        static List<Personal> personales = new List<Personal>();
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxCarneEstudiante.Enabled = false;
            ButtonIngresarAlumno.Enabled = false;
            TextBoxIdProfesor.Enabled = false;
            TextBoxTituloUniversitario.Enabled = false;
            ButtonIngresarProfesor.Enabled = false;
            CalendarInicioLabores.Enabled = false;
            CalendarFinLabores.Enabled = false;
            TextBoxNumeroIGSS.Enabled = false;  
            TextBoxProfesion.Enabled = false;
            ButtonIngresarPersonal.Enabled = false;
            
        }

        
        protected void CheckBoxEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        protected void GuardarPuesto()
        {
            
            string json = JsonConvert.SerializeObject(puestos);           
            string archivo = Server.MapPath("Puesto.json");           
            System.IO.File.WriteAllText(archivo, json);
        }
        

        protected void ButtonElegir_Click(object sender, EventArgs e)
        {
            Alumno alumnoTemp = new Alumno();
            Profesor profesorTemp = new Profesor();
            Personal personalTemp = new Personal();

            if(DropDownListPuesto.SelectedIndex == 1)
            {
                TextBoxCarneEstudiante.Enabled = true;
                ButtonIngresarAlumno.Enabled = true;
                TextBoxIdProfesor.Enabled = false;
                TextBoxTituloUniversitario.Enabled = false;
                ButtonIngresarProfesor.Enabled = false;
                CalendarInicioLabores.Enabled = false;
                CalendarFinLabores.Enabled = false;
                TextBoxNumeroIGSS.Enabled = false;
                TextBoxProfesion.Enabled = false;
                ButtonIngresarPersonal.Enabled = false;

                alumnoTemp.nombre = TextBoxNombre.Text;
                alumnoTemp.apellido = TextBoxApellido.Text;
                alumnoTemp.direccion = TextBoxDireccion.Text;
                alumnoTemp.fechaNacimiento = CalendarFechaNacimiento.SelectedDate;
                alumnoTemp.carne = TextBoxCarneEstudiante.Text;
                alumnos.Add(alumnoTemp);
               

            }
            if(DropDownListPuesto.SelectedIndex == 2)
            {
                TextBoxCarneEstudiante.Enabled = false;
                ButtonIngresarAlumno.Enabled = false;
                TextBoxIdProfesor.Enabled = true;
                TextBoxTituloUniversitario.Enabled = true;
                ButtonIngresarProfesor.Enabled = true;
                CalendarInicioLabores.Enabled = false;
                CalendarFinLabores.Enabled = false;
                TextBoxNumeroIGSS.Enabled = false;
                TextBoxProfesion.Enabled = false;
                ButtonIngresarPersonal.Enabled = false;

                profesorTemp.nombre = TextBoxNombre.Text;
                profesorTemp.apellido = TextBoxApellido.Text;   
                profesorTemp.direccion= TextBoxDireccion.Text;
                profesorTemp.fechaNacimiento= CalendarFechaNacimiento.SelectedDate;
                profesorTemp.idProfesr = TextBoxIdProfesor.Text;
                profesorTemp.titulo = TextBoxTituloUniversitario.Text;
                profesores.Add(profesorTemp);
                
            }
            if (DropDownListPuesto.SelectedIndex == 3)
            {
                TextBoxCarneEstudiante.Enabled = false;
                ButtonIngresarAlumno.Enabled = false;
                TextBoxIdProfesor.Enabled = false;
                TextBoxTituloUniversitario.Enabled = false;
                ButtonIngresarProfesor.Enabled = false;
                CalendarInicioLabores.Enabled = true;
                CalendarFinLabores.Enabled = true;
                TextBoxNumeroIGSS.Enabled = true;
                TextBoxProfesion.Enabled = true;
                ButtonIngresarPersonal.Enabled = true;

                personalTemp.nombre = TextBoxNombre.Text;
                personalTemp.apellido = TextBoxApellido.Text;
                personalTemp.direccion = TextBoxDireccion.Text;
                personalTemp.fechaNacimiento = CalendarFechaNacimiento.SelectedDate;
                personalTemp.fechaInicioLabor = CalendarInicioLabores.SelectedDate;
                personalTemp.fechaFinLabor = CalendarFinLabores.SelectedDate;
                personalTemp.noIgss = TextBoxNumeroIGSS.Text;
                personalTemp.profesion = TextBoxProfesion.Text;
                personales.Add(personalTemp);

            }



        }

        protected void Limpiar()
        {
            TextBoxCarneEstudiante.Text = "";           
            TextBoxIdProfesor.Text = "";
            TextBoxTituloUniversitario.Text = "";                      
            TextBoxNumeroIGSS.Text = "";
            TextBoxProfesion.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDireccion.Text = "";
        }
        protected void ButtonIngresarAlumno_Click(object sender, EventArgs e)
        {

            
                Puesto puesto = new Puesto();
            puesto.puesto = DropDownListPuesto.Text;
            puesto.alumno = alumnos.ToArray().ToList();
            puestos.Add(puesto);
            GuardarPuesto();
            Limpiar();    
            
           
        }

        protected void ButtonIngresarProfesor_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();
            puesto.puesto = DropDownListPuesto.Text;
            puesto.profesor = profesores.ToArray().ToList();
            puestos.Add(puesto);
            GuardarPuesto();
            Limpiar();

        }

        protected void ButtonIngresarPersonal_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();
            puesto.puesto = DropDownListPuesto.Text;
            puesto.personal = personales.ToArray().ToList();
            puestos.Add(puesto);
            GuardarPuesto();
            Limpiar();


        }

        protected void DropDownListPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                   
             
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if(DropDownListPuesto.SelectedIndex == 1)
            {
                TextBoxCarneEstudiante.Enabled = true;
                ButtonIngresarAlumno.Enabled = true;
                TextBoxIdProfesor.Enabled = false;
                TextBoxTituloUniversitario.Enabled = false;
                ButtonIngresarProfesor.Enabled = false;
                CalendarInicioLabores.Enabled = false;
                CalendarFinLabores.Enabled = false;
                TextBoxNumeroIGSS.Enabled = false;
                TextBoxProfesion.Enabled = false;
                ButtonIngresarPersonal.Enabled = false;


            }
            
            if(DropDownListPuesto.SelectedIndex == 2)
            {
                TextBoxCarneEstudiante.Enabled = false;
                ButtonIngresarAlumno.Enabled = false;
                TextBoxIdProfesor.Enabled = true;
                TextBoxTituloUniversitario.Enabled = true;
                ButtonIngresarProfesor.Enabled = true;
                CalendarInicioLabores.Enabled = false;
                CalendarFinLabores.Enabled = false;
                TextBoxNumeroIGSS.Enabled = false;
                TextBoxProfesion.Enabled = false;
                ButtonIngresarPersonal.Enabled = false;
            }
            if (DropDownListPuesto.SelectedIndex == 3)
            {
                TextBoxCarneEstudiante.Enabled = false;
                ButtonIngresarAlumno.Enabled = false;
                TextBoxIdProfesor.Enabled = false;
                TextBoxTituloUniversitario.Enabled = false;
                ButtonIngresarProfesor.Enabled = false;
                CalendarInicioLabores.Enabled = true;
                CalendarFinLabores.Enabled = true;
                TextBoxNumeroIGSS.Enabled = true;
                TextBoxProfesion.Enabled = true;
                ButtonIngresarPersonal.Enabled = true;
            }
        }

        protected void CalendarFechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}