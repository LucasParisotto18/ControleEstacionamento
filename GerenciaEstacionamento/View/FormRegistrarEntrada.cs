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
    public partial class FormRegistrarEntrada : Form
    {

        private String placaCarro;
        private DateTime dataEntrada;

        public String getPlacaCarro()
        {
            return placaCarro;
        }

        public DateTime getDataEntrada()
        {
            return dataEntrada;
        }

        public void setPlacaCarro(String placaCarro)
        {
            this.placaCarro = placaCarro;
        }

        public void setDataEntrada(DateTime dataEntrada)
        {
            this.dataEntrada = dataEntrada;
        }

        public FormRegistrarEntrada()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            setPlacaCarro(textBoxPlaca.Text);

            string formatoDataHora = "dd/MM/yyyy HH:mm:ss";
            setDataEntrada(DateTime.ParseExact(textBoxData.Text, formatoDataHora, System.Globalization.CultureInfo.InvariantCulture));


            MessageBox.Show($"Entrada Adicionada!" +
                $"\n\n Placa do carro: {getPlacaCarro()}\n " +
                $"  Data de entrada: {getDataEntrada()}");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
