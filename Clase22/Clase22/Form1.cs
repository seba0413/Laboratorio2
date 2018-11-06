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

namespace Clase22
{
    public partial class Form1 : Form
    {
        private int[] numero = { 0, 0, 0, 0 };
        Thread t1 = null;
        Thread t2 = null;
        Thread t3 = null;
        Thread t4 = null;

        private void metodo(object o)
        {
            int pos = (int)o;

            while(numero[pos] < 10000)
            {
                numero[pos]++;
                System.Threading.Thread.Sleep(30);
                mostrar(numero[pos], pos);
            }          
        }

        private void mostrar(int num, int pos)
        {
            switch(pos)
            {
                case 0:
                    if (this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox1.Text = num.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox1.Text = num.ToString();
                    }
                    break;

                case 1:
                    if (this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox2.Text = num.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox2.Text = num.ToString();
                    }
                    break;

                case 2:
                    if (this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox3.Text = num.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox3.Text = num.ToString();
                    }
                    break;

                case 3:
                    if (this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox4.Text = num.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox4.Text = num.ToString();
                    }
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            t1 = new Thread(new ParameterizedThreadStart(metodo));
            t2 = new Thread(new ParameterizedThreadStart(metodo));
            t3 = new Thread(new ParameterizedThreadStart(metodo));
            t4 = new Thread(new ParameterizedThreadStart(metodo));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Start(0);
            t2.Start(1);
            t3.Start(2);
            t4.Start(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.IsAlive)
                t1.Abort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t2.IsAlive)
                t2.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t3.IsAlive)
                t3.Abort();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t4.IsAlive)
                t4.Abort();
        }
    }
}
