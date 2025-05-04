using GerenciaEstacionamento.Model;
using GerenciaEstacionamento.Service;
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
    public partial class FormRegistrarSaida : Form
    {
        private List<RegistroEstacionamento> ListaRegistrosEstacionamento = new List<RegistroEstacionamento>();
        private List<TabelaPrecos> ListaTabelaPrecos = new List<TabelaPrecos>();
        EstacionamentoService estacionamentoService = new EstacionamentoService();

        public FormRegistrarSaida()
        {
            InitializeComponent();
        }

        public List<RegistroEstacionamento> getRegistroEstacionamentos()
        {
            return ListaRegistrosEstacionamento;
        }

        public FormRegistrarSaida(List<RegistroEstacionamento> ListaRegistrosEstacionamento, List<TabelaPrecos> listaTabelaPreco)
        {
            InitializeComponent();
            this.ListaRegistrosEstacionamento = ListaRegistrosEstacionamento;
            this.ListaTabelaPrecos = listaTabelaPreco;
            AtualizarDataGridView();
             
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxHorario.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um carro para registrar a Saída.");
                return;
            }

            // IndexLinha = dataGridView1.SelectedRows[0].Index;
            //int IdLinhaSelecionada = ListaRegistrosEstacionamento[IndexLinha].getId();
            
            int IdLinhaSelecionada = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            RegistroEstacionamento estacionamentoSelecionado = new RegistroEstacionamento();
            //MessageBox.Show($"Teste {IndexLinha}");

            estacionamentoSelecionado = ListaRegistrosEstacionamento.FirstOrDefault(registroAtual => registroAtual.getId() == IdLinhaSelecionada);

            if (estacionamentoSelecionado.getDataEntrada() >= DateTime.Parse(textBoxHorario.Text))
            {
                MessageBox.Show("Data de saída deve ser maior que a data de entrada.");
                
            } else
            {
                estacionamentoSelecionado.setDataSaida(DateTime.Parse(textBoxHorario.Text));
                estacionamentoSelecionado.setIsEstacionado(false);
                TimeSpan tempoEstacionado = estacionamentoService.calculartempoEstacionado(estacionamentoSelecionado.getDataEntrada(), DateTime.Parse(textBoxHorario.Text));
                estacionamentoSelecionado.setTempoEstacionado(tempoEstacionado);
                decimal valorCobrado = estacionamentoService.calcularValorCobrado(estacionamentoSelecionado, ListaTabelaPrecos);
                estacionamentoSelecionado.setValorCobrado(valorCobrado);
                estacionamentoSelecionado.setTotalAPagar(valorCobrado);

                MessageBox.Show($"Saída registrada com sucesso! \n\n" +
                    $"  Placa: {estacionamentoSelecionado.getPlacaCarro()} \n" +
                    $"  Data Entrada: {estacionamentoSelecionado.getDataEntrada()} \n" +
                    $"  Data Saída: {estacionamentoSelecionado.getDataSaida()} \n" +
                    $"  Tempo Estacionado: {estacionamentoSelecionado.getTempoEstacionado()} \n\n" +
                    $"  Valor a Pagar: {estacionamentoSelecionado.getValorCobrado()}");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AtualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var registro in ListaRegistrosEstacionamento)
            {
                if (registro.getIsEstacionado().Equals(true))
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["ID"].Value = registro.getId();
                    dataGridView1.Rows[index].Cells["placaCarro"].Value = registro.getPlacaCarro();
                    dataGridView1.Rows[index].Cells["dataEntrada"].Value = registro.getDataEntrada();
                }
               

            }
        }
    }
}
