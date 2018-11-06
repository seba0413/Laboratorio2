using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Thread t1;
   
        public Form1()
        {
            InitializeComponent();
            t1 = new Thread(AsignarHora);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           t1.Start();           
        }

        private void AsignarHora()
        {

            while (true)
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                string fechaActual = dt.ToString("dd/MM/yyyy hh:mm:ss");
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.lblHora.Text = fechaActual;
                    }
                    );
                }
                else
                {
                    this.lblHora.Text = fechaActual;
                }

                Thread.Sleep(1000);
            }

                   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
