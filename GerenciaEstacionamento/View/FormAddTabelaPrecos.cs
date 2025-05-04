using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaEstacionamento.View
{
    public partial class FormAddTabelaPrecos : Form
    {
        public FormAddTabelaPrecos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1HoraAtual_Click(object sender, EventArgs e)
        {
            textBoxInicioVigencia.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button2HoraAtual_Click(object sender, EventArgs e)
        {
            textBoxFimVigencia.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
