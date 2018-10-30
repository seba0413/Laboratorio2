using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        string archivo;

        public Form1()
        {
            InitializeComponent();
            this.mnuGuardar.Enabled = false;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de texto |*txt|Archivo DAT|*.dat;*.bin";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                archivo = openFileDialog1.FileName;
                this.mnuGuardar.Enabled = true;
                StreamReader sr = new StreamReader(archivo);
                rtbTexto.Text = sr.ReadToEnd();
                sr.Close();
            }            
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(archivo);
            sw.Write(rtbTexto.Text);
            sw.Close();
        }

        private void mnuGuardarComo_Click(object sender, EventArgs e)
        {
            string archivo;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(archivo);
                sw.Write(rtbTexto.Text);
                sw.Close();
            }
        }
    }
}
