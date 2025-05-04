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
        EstacionamentoService estacionamentoService = new EstacionamentoService();

        public FormRegistrarSaida()
        {
            InitializeComponent();
        }

        public FormRegistrarSaida(List<RegistroEstacionamento> ListaRegistrosEstacionamento)
        {
            InitializeComponent();
            this.ListaRegistrosEstacionamento = ListaRegistrosEstacionamento;
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

            int IndexLinha = dataGridView1.SelectedRows[0].Index;
            RegistroEstacionamento estacionamentoSelecionado = new RegistroEstacionamento();

            estacionamentoSelecionado = ListaRegistrosEstacionamento[IndexLinha];

            estacionamentoSelecionado.setDataSaida(DateTime.Parse(textBoxHorario.Text));
            estacionamentoSelecionado.setIsEstacionado(false);
            estacionamentoSelecionado.setTempoEstacionado(estacionamentoService.calculartempoEstacionado(estacionamentoSelecionado.getDataEntrada(), estacionamentoSelecionado.getDataSaida().Value));


            this.DialogResult = DialogResult.OK;
            this.Close();

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
                    dataGridView1.Rows[index].Cells["dataSaida"].Value = registro.getDataSaida();
                    if (registro.getIsEstacionado().Equals(true))
                    {
                        dataGridView1.Rows[index].Cells["isEstacionado"].Value = "Sim";
                    }
                    else
                    {
                        dataGridView1.Rows[index].Cells["isEstacionado"].Value = "Não";
                    }
                    dataGridView1.Rows[index].Cells["tempoEstacionado"].Value = registro.getTempoEstacionado();
                    dataGridView1.Rows[index].Cells["valorCobrado"].Value = registro.getValorCobrado();
                    dataGridView1.Rows[index].Cells["totalAPagar"].Value = registro.getTotalAPagar();
                }
               

            }
        }
    }
}
