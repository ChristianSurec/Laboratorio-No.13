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
    public partial class WebFormEditarBorrarProfesor : System.Web.UI.Page
    {
       
        static List<Puesto> puestos = new List<Puesto>();
        static string encontrarID;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            if (DropDownListEdtiarBorrar.SelectedIndex == 0)
            {
                TextBoxIdProfesorEditar.Enabled = false;
                ButtonBuscarEditar.Enabled = false;
                TextBoxEditarNombre.Enabled = false;
                TextBoxEditarApellido.Enabled = false;
                TextBoxEditarDireccion.Enabled = false;
                TextBoxEditarFechaNaEditar.Enabled = false;
                Calendar1.Enabled = false;
                TextBoxEditarTitulo.Enabled = false;
                ButtonEditar.Enabled = false;

                TextBoxIdProfesorBorrar.Enabled = false;
                ButtonBuscarBorrar.Enabled = false;
                TextBoxNombreBorrar.Enabled = false;
                TextBoxApellidoBorrar.Enabled = false;
                TextBoxDireccionBorrar.Enabled = false;
                TextBoxFechaNaBorrar.Enabled = false;
                TextBoxTituloBorrar.Enabled = false;
                ButtonBorrar.Enabled = false;

                

        }

        
    }
        protected void condicion()
        {
            if (DropDownListEdtiarBorrar.SelectedIndex == 1)
            {
                TextBoxIdProfesorEditar.Enabled = true;
                ButtonBuscarEditar.Enabled = true;
                TextBoxEditarNombre.Enabled = false;
                TextBoxEditarApellido.Enabled = false;
                TextBoxEditarDireccion.Enabled = false;
                TextBoxEditarFechaNaEditar.Enabled = false;
                Calendar1.Enabled = false;
                TextBoxEditarTitulo.Enabled = false;
                ButtonEditar.Enabled = false;

                TextBoxIdProfesorBorrar.Enabled = false;
                ButtonBuscarBorrar.Enabled = false;
                TextBoxNombreBorrar.Enabled = false;
                TextBoxApellidoBorrar.Enabled = false;
                TextBoxDireccionBorrar.Enabled = false;
                TextBoxFechaNaBorrar.Enabled = false;
                TextBoxTituloBorrar.Enabled = false;
                ButtonBorrar.Enabled = false;
            }
            if (DropDownListEdtiarBorrar.SelectedIndex == 2)
            {
                TextBoxIdProfesorEditar.Enabled = false;
                ButtonBuscarEditar.Enabled = false;
                TextBoxEditarNombre.Enabled = false;
                TextBoxEditarApellido.Enabled = false;
                TextBoxEditarDireccion.Enabled = false;
                TextBoxEditarFechaNaEditar.Enabled = false;
                Calendar1.Enabled = false;
                TextBoxEditarTitulo.Enabled = false;
                ButtonEditar.Enabled = false;

                TextBoxIdProfesorBorrar.Enabled = true;
                ButtonBuscarBorrar.Enabled = true;
                TextBoxNombreBorrar.Enabled = false;
                TextBoxApellidoBorrar.Enabled = false;
                TextBoxDireccionBorrar.Enabled = false;
                TextBoxFechaNaBorrar.Enabled = false;
                TextBoxTituloBorrar.Enabled = false;
                ButtonBorrar.Enabled = false;
            }

        }
        protected void ButtonElegir_Click(object sender, EventArgs e)
        {
            condicion();
        }

        protected void ButtonBuscarEditar_Click(object sender, EventArgs e)
        {
            encontrarID = TextBoxIdProfesorEditar.Text;
            bool encontrado = false;

            foreach(var a in puestos)
            {
                Profesor editarProfesor = a.profesor.Find(c => c.idProfesr == encontrarID);
               if (editarProfesor != null)
                {
                    TextBoxEditarNombre.Text = editarProfesor.nombre;
                    TextBoxEditarApellido.Text = editarProfesor.apellido;
                    TextBoxEditarDireccion.Text = editarProfesor.direccion;
                    TextBoxEditarFechaNaEditar.Text = Convert.ToString(editarProfesor.fechaNacimiento);
                    Calendar1.SelectedDate = editarProfesor.fechaNacimiento;
                    TextBoxEditarTitulo.Text = editarProfesor.titulo; 
                    encontrado = true;

                    TextBoxIdProfesorEditar.Enabled = true;
                    ButtonBuscarEditar.Enabled = true;
                    TextBoxEditarNombre.Enabled = true;
                    TextBoxEditarApellido.Enabled = true;
                    TextBoxEditarDireccion.Enabled = true;
                    TextBoxEditarFechaNaEditar.Enabled = true;
                    Calendar1.Enabled = true;
                    TextBoxEditarTitulo.Enabled = true;
                    ButtonEditar.Enabled = true;

                    TextBoxIdProfesorBorrar.Enabled = false;
                    ButtonBuscarBorrar.Enabled = false;
                    TextBoxNombreBorrar.Enabled = false;
                    TextBoxApellidoBorrar.Enabled = false;
                    TextBoxDireccionBorrar.Enabled = false;
                    TextBoxFechaNaBorrar.Enabled = false;
                    TextBoxTituloBorrar.Enabled = false;
                    ButtonBorrar.Enabled = false;
                }
            }
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            foreach(var a in puestos)
            {
                int editarProfesor = a.profesor.FindIndex(c => c.idProfesr == encontrarID);
                if(editarProfesor > -1)
                {
                    a.profesor[editarProfesor].nombre = TextBoxEditarNombre.Text;
                    a.profesor[editarProfesor].apellido = TextBoxEditarApellido.Text;
                    a.profesor[editarProfesor].direccion = TextBoxEditarDireccion.Text;
                    a.profesor[editarProfesor].fechaNacimiento = Calendar1.SelectedDate;
                    a.profesor[editarProfesor].titulo = TextBoxEditarTitulo.Text;
                }
            }
            GuardarPuesto();
        }

        protected void ButtonBuscarBorrar_Click(object sender, EventArgs e)
        {
            encontrarID = TextBoxIdProfesorEditar.Text;
            bool encontrado = false;

            foreach (var a in puestos)
            {
                Profesor borrarProfesor = a.profesor.Find(c => c.idProfesr == encontrarID);
                if (borrarProfesor != null)
                {
                    TextBoxEditarNombre.Text = borrarProfesor.nombre;
                    TextBoxEditarApellido.Text = borrarProfesor.apellido;
                    TextBoxEditarDireccion.Text = borrarProfesor.direccion;
                    TextBoxEditarFechaNaEditar.Text = Convert.ToString(borrarProfesor.fechaNacimiento);                    
                    TextBoxEditarTitulo.Text = borrarProfesor.titulo;
                    encontrado = true;

                    TextBoxIdProfesorEditar.Enabled = false;
                    ButtonBuscarEditar.Enabled = false;
                    TextBoxEditarNombre.Enabled = false;
                    TextBoxEditarApellido.Enabled = false;
                    TextBoxEditarDireccion.Enabled = false;
                    TextBoxEditarFechaNaEditar.Enabled = false;
                    Calendar1.Enabled = false;
                    TextBoxEditarTitulo.Enabled = false;
                    ButtonEditar.Enabled = false;

                    TextBoxIdProfesorBorrar.Enabled = true;
                    ButtonBuscarBorrar.Enabled = true;
                    TextBoxNombreBorrar.Enabled = true;
                    TextBoxApellidoBorrar.Enabled = true;
                    TextBoxDireccionBorrar.Enabled = true;
                    TextBoxFechaNaBorrar.Enabled = true;
                    TextBoxTituloBorrar.Enabled = true;
                    ButtonBorrar.Enabled = true;
                }
            }

        }

        protected void ButtonBorrar_Click(object sender, EventArgs e)
        {
            foreach(var a in puestos)
            {
                Profesor borrarProfesor = a.profesor.Find(c => c.idProfesr == encontrarID);
                if(borrarProfesor != null)
                {
                    a.profesor.Remove(borrarProfesor);
                }
            }
            GuardarPuesto();
        }
    }
}



