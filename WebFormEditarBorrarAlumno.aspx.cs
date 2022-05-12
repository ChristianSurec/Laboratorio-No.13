using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_No._13
{
    public partial class WebFormEditarBorrarAlumno : System.Web.UI.Page
    {
          
        
        static List<Puesto> puestos = new List<Puesto>();
        static string encontrarCarne;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            if(DropDownListEditarBorrar.SelectedIndex == 0)
            {
                TextBoxNombreEditar.Enabled = false;
                TextBoxApellidoEditar.Enabled = false;  
                TextBoxDireccionEditar.Enabled = false;
                TextBoxFechaNaEditar.Enabled = false;
                CalendarEditar.Enabled = false;
                TextBoxNombreBorrar.Enabled = false;
                TextBoxApellidoBorrar.Enabled=false;
                TextBoxDireccionBorrar.Enabled = false;
                TextBoxFechaNaBorrar.Enabled = false;
                ButtonBorrarDatos.Enabled = false;
                ButtonGuardarDatos.Enabled = false;
                ButtonBuscarEditar.Enabled = false;
                ButtonBuscarEliminar.Enabled = false;
                TextBoxCarneEditar.Enabled = false; 
                TextBoxCarneBorrar.Enabled = false;
            }

            
        }
        protected void GuardarPuesto()
        {

            string json = JsonConvert.SerializeObject(puestos);
            string archivo = Server.MapPath("Puesto.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void CargarPuestos()
        {
                      
            string archivo = Server.MapPath("Puesto.json");          
            StreamReader jsonStream = File.OpenText(archivo);            
            string json = jsonStream.ReadToEnd();            
            jsonStream.Close();           
            puestos = JsonConvert.DeserializeObject<List<Puesto>>(json);
        }
        
        protected void condicion()
        {
            if(DropDownListEditarBorrar.SelectedIndex == 1 )
            {
                TextBoxNombreEditar.Enabled = false;
                TextBoxApellidoEditar.Enabled = false;
                TextBoxDireccionEditar.Enabled = false;
                TextBoxFechaNaEditar.Enabled = false;
                CalendarEditar.Enabled = false;
                TextBoxNombreBorrar.Enabled = false;
                TextBoxApellidoBorrar.Enabled = false;
                TextBoxDireccionBorrar.Enabled = false;
                TextBoxFechaNaBorrar.Enabled = false;
                ButtonBorrarDatos.Enabled = false;
                ButtonGuardarDatos.Enabled = false ;
                ButtonBuscarEditar.Enabled = true;
                ButtonBuscarEliminar.Enabled = false;
                TextBoxCarneEditar.Enabled = true;
                TextBoxCarneBorrar.Enabled = false;

            }

            if (DropDownListEditarBorrar.SelectedIndex == 2 )
            {
                TextBoxNombreEditar.Enabled = false;
                TextBoxApellidoEditar.Enabled = false;
                TextBoxDireccionEditar.Enabled = false;
                TextBoxFechaNaEditar.Enabled = false;
                CalendarEditar.Enabled = false;
                TextBoxNombreBorrar.Enabled = true;
                TextBoxApellidoBorrar.Enabled = true;
                TextBoxDireccionBorrar.Enabled = true;
                TextBoxFechaNaBorrar.Enabled = true;
                ButtonBorrarDatos.Enabled = true;
                ButtonGuardarDatos.Enabled = false;
                ButtonBuscarEditar.Enabled = false;
                ButtonBuscarEliminar.Enabled = true;
                TextBoxCarneEditar.Enabled = false;
                TextBoxCarneBorrar.Enabled = true;

            }
        }
        protected void GuardarEstudiante()
        {

            string json = JsonConvert.SerializeObject(puestos);
            string archivo = Server.MapPath("Puesto.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        
        protected void ButtonBuscarAlumno_Click(object sender, EventArgs e)
        {
            encontrarCarne = TextBoxCarneEditar.Text;
                bool encontrado = false;

                foreach(var a in puestos)
                {
                Alumno editarAlumno = a.alumno.Find(c => c.carne == encontrarCarne);
                if(editarAlumno != null)
                {
                    TextBoxNombreEditar.Text = editarAlumno.nombre;
                    TextBoxApellidoEditar.Text = editarAlumno.apellido;
                    editarAlumno.fechaNacimiento = CalendarEditar.SelectedDate;
                    encontrado = true;
                    
                        TextBoxNombreEditar.Enabled = true;
                        TextBoxApellidoEditar.Enabled = true;
                        TextBoxDireccionEditar.Enabled = true;
                        TextBoxFechaNaEditar.Enabled = false;
                        CalendarEditar.Enabled = true;
                        TextBoxNombreBorrar.Enabled = false;
                        TextBoxApellidoBorrar.Enabled = false;
                        TextBoxDireccionBorrar.Enabled = false;
                        TextBoxFechaNaBorrar.Enabled = false;
                        ButtonBorrarDatos.Enabled = false;
                        ButtonGuardarDatos.Enabled = false;
                        ButtonBuscarEditar.Enabled = true;
                        ButtonBuscarEliminar.Enabled = false;
                        TextBoxCarneEditar.Enabled = true;
                        TextBoxCarneBorrar.Enabled = false;
                    
                }

                }
                if(!encontrado)
            {
                Response.Write("<script>alert('El alumno no se pudo encontrar o no está registrado')</script>");
                TextBoxNombreEditar.Text = "";
                TextBoxApellidoEditar.Text = "";
                TextBoxCarneEditar.Text = "";
            }
            
        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            condicion();
            
        }

        protected void ButtonGuardarDatos_Click(object sender, EventArgs e)
        {
            foreach( var u in puestos)
            {
                int editarAlumno = u.alumno.FindIndex(c => c.carne == encontrarCarne);

                if(editarAlumno > -1)
                {
                    u.alumno[editarAlumno].nombre = TextBoxNombreEditar.Text;
                    u.alumno[editarAlumno].apellido = TextBoxApellidoEditar.Text;
                    GuardarPuesto();
                }
            }
        }

        protected void ButtonBuscarEliminar_Click(object sender, EventArgs e)
        {
            encontrarCarne = TextBoxCarneEditar.Text;
            bool encontrado = false;

            foreach (var a in puestos)
            {
                Alumno borrarAlumno = a.alumno.Find(c => c.carne == encontrarCarne);
                if (borrarAlumno != null)
                {
                    TextBoxNombreEditar.Text = borrarAlumno.nombre;
                    TextBoxApellidoEditar.Text = borrarAlumno.apellido;
                    TextBoxDireccionBorrar.Text = borrarAlumno.direccion;
                    TextBoxFechaNaEditar.Text = Convert.ToString(borrarAlumno.fechaNacimiento);
                    encontrado = true;

                    TextBoxNombreEditar.Enabled = true;
                    TextBoxApellidoEditar.Enabled = true;
                    TextBoxDireccionEditar.Enabled = true;
                    TextBoxFechaNaEditar.Enabled = false;
                    CalendarEditar.Enabled = true;
                    TextBoxNombreBorrar.Enabled = false;
                    TextBoxApellidoBorrar.Enabled = false;
                    TextBoxDireccionBorrar.Enabled = false;
                    TextBoxFechaNaBorrar.Enabled = false;
                    ButtonBorrarDatos.Enabled = false;
                    ButtonGuardarDatos.Enabled = false;
                    ButtonBuscarEditar.Enabled = true;
                    ButtonBuscarEliminar.Enabled = false;
                    TextBoxCarneEditar.Enabled = true;
                    TextBoxCarneBorrar.Enabled = false;

                }

            }
            if (!encontrado)
            {
                Response.Write("<script>alert('El alumno no se pudo encontrar o no está registrado')</script>");
                TextBoxNombreEditar.Text = "";
                TextBoxApellidoEditar.Text = "";
                TextBoxCarneEditar.Text = "";
            }
        }

        protected void ButtonBorrarDatos_Click(object sender, EventArgs e)
        {
            foreach(var a in puestos)
            {
                Alumno borrarAlumno = a.alumno.Find(c => c.carne == encontrarCarne);
                {
                    if(borrarAlumno != null)
                    {
                        a.alumno.Remove(borrarAlumno);
                    }
                }
            }
            GuardarPuesto();
        }
    }
}