using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista_Form
{
    public partial class Vista : Form
    {
        Curso curso;
        Profesor profesor;
        Alumno alumno;
        
        public Vista()
        {
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            short anio = (short)nudAnioCurso.Value;
            string nombre = txtNombreProfe.Text;
            string apellido = txtApellidoProfe.Text;
            string documento = txtDni.Text;
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            profesor = new Profesor(nombre, apellido, documento, fechaIngreso);
            curso = new Curso(anio, division, profesor);

            MessageBox.Show("Curso creado correctamente", "Mensaje", MessageBoxButtons.OK);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(curso == null)            
                MessageBox.Show("No existe ningun curso", "Error", MessageBoxButtons.OK);
            
            else            
                rtbDatos.Text = (string)curso;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string legajo = txtLegajo.Text;
            short anio = (short)nudAnio.Value;
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
            alumno = new Alumno(nombre, apellido, legajo, anio, division);

            curso += alumno;

            MessageBox.Show("Alumno agregado al curso", "Mensaje", MessageBoxButtons.OK);
        }
    }
}
