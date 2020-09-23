using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeLucia = 33;
            int idadeGiovana = 17;
            int idadeTiago = 33;
            int media = (idadeGiovana + idadeLucia + idadeTiago )/ 3;
            string mensagem = "A média das idades é:" + media;
            MessageBox.Show(mensagem);
        }
    }
}
