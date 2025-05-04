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
        private DateTime dataInicioVigencia;
        private DateTime dataFimVigencia;
        private decimal valorHoraInicial;
        private decimal valorHoraAdicional;




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
            string formatoData = "dd/MM/yyyy HH:mm:ss";
            setDataInicioVigencia(DateTime.Parse(textBoxInicioVigencia.Text));
            setDataFimVigencia(DateTime.Parse(textBoxFimVigencia.Text));
            setValorHoraInicial(decimal.Parse(textBoxCustoInicial.Text));
            setValorHoraAdicional(decimal.Parse(textBoxCustoAdicional.Text));

            MessageBox.Show($"Tabela Adicionada! \n\n" +
                $"  Inicio Vigência: {getDataInicioVigencia()}\n" +
                $"  Final Vigência: {getDataFimVigencia()} \n" +
                $"  Valor Hora Inicial: {getValorHoraInicial()} \n" +
                $"  Valor Hora Adicional: {getValorHoraAdicional()} \n");

            this.DialogResult = DialogResult.OK;
            this.Close();

        }



        public DateTime getDataInicioVigencia()
        {
            return dataInicioVigencia;
        }
        public DateTime getDataFimVigencia()
        {
            return dataFimVigencia;
        }
        public decimal getValorHoraInicial()
        {
            return valorHoraInicial;
        }
        public decimal getValorHoraAdicional()
        {
            return valorHoraAdicional;
        }

        public void setDataInicioVigencia(DateTime dataInicioVigencia)
        {
            this.dataInicioVigencia = dataInicioVigencia;
        }
        public void setDataFimVigencia(DateTime dataFimVigencia)
        {
            this.dataFimVigencia = dataFimVigencia;
        }
        public void setValorHoraInicial(decimal valorHoraInicial)
        {
            this.valorHoraInicial = valorHoraInicial;
        }
        public void setValorHoraAdicional(decimal valorHoraAdicional)
        {
            this.valorHoraAdicional = valorHoraAdicional;
        }
    }
}
