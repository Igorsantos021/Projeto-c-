using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dado = new Random();
            int valor;

            valor = dado.Next(1, 4);

            if (valor == 1)
            {
                evento1.Visible = true;
                evento2.Visible = false;
                evento3.Visible = false;
            }

            if(valor == 2)
            {
                evento1.Visible = false;
                evento2.Visible = true;
                evento3.Visible = false;
            }

            if(valor == 3)
            {
                evento1.Visible = false;
                evento2.Visible = false;
                evento3.Visible = true;
            }

            resultado.Text = Convert.ToString(valor);
        }
    }
}
