using GerenciaEstacionamento.Controller;
using GerenciaEstacionamento.Model;
using GerenciaEstacionamento.Service;
using GerenciaEstacionamento.View;

namespace GerenciaEstacionamento
{
    public partial class Form1 : Form
    {

        Importador imp = new Importador();
        List<RegistroEstacionamento> listaRegistroEstacionamento = new List<RegistroEstacionamento>();
        List<TabelaPrecos> listaTabelaPrecos = new List<TabelaPrecos>();
        EstacionamentoService estacionamentoService = new EstacionamentoService();

        String caminhoArqEstacionamento = "";
        String caminhoArqTabelaPrecos = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formEntrada = new FormRegistrarEntrada();
            if (formEntrada.ShowDialog() == DialogResult.OK)
            {
                int novoID = estacionamentoService.getUltimoID(listaRegistroEstacionamento) + 1;
                string placa = formEntrada.getPlacaCarro();
                DateTime horaEntrada = formEntrada.getDataEntrada();

                RegistroEstacionamento registro = new RegistroEstacionamento(novoID, placa, horaEntrada);
                listaRegistroEstacionamento.Add(registro);

                imp.exportarDadosEstacionamento(listaRegistroEstacionamento, caminhoArqEstacionamento);
                AtualizarDataGridView();



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoArqEstacionamento = openFileDialog1.FileName;
                MessageBox.Show($"Arquivo selecionado: {caminhoArqEstacionamento}");
                listaRegistroEstacionamento = imp.importarDadosEstacionamento(caminhoArqEstacionamento);

                AtualizarDataGridView();



                //MessageBox.Show($"Arquivo importad {listaRegistroEstacionamento.Count} registros encontrados");
                //MessageBox.Show($"Ultimo id: {estacionamentoService.getUltimoID(listaRegistroEstacionamento)}");
            }
        }

        private void ArqTabelaPreco_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoArqTabelaPrecos = openFileDialog1.FileName;
                MessageBox.Show($"Arquivo selecionado: {caminhoArqTabelaPrecos}");
                listaTabelaPrecos = imp.importarDadosTabelaPreco(caminhoArqTabelaPrecos);
            }
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var registro in listaRegistroEstacionamento)
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

        private void atualizarGridViewSaidas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            foreach (var registro in listaRegistroEstacionamento)
            {
                if (registro.getIsEstacionado().Equals(false))
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["ID"].Value = registro.getId();
                    dataGridView1.Rows[index].Cells["placaCarro"].Value = registro.getPlacaCarro();
                    dataGridView1.Rows[index].Cells["dataEntrada"].Value = registro.getDataEntrada();
                    dataGridView1.Rows[index].Cells["dataSaida"].Value = registro.getDataSaida();
                    dataGridView1.Rows[index].Cells["isEstacionado"].Value = "Não";
                    dataGridView1.Rows[index].Cells["tempoEstacionado"].Value = registro.getTempoEstacionado();
                    dataGridView1.Rows[index].Cells["valorCobrado"].Value = registro.getValorCobrado();
                    dataGridView1.Rows[index].Cells["totalAPagar"].Value = registro.getTotalAPagar();
                }
            }
        }

        private void atualizarGridViewEntradas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            foreach (var registro in listaRegistroEstacionamento)
            {
                if (registro.getIsEstacionado().Equals(true))
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["ID"].Value = registro.getId();
                    dataGridView1.Rows[index].Cells["placaCarro"].Value = registro.getPlacaCarro();
                    dataGridView1.Rows[index].Cells["dataEntrada"].Value = registro.getDataEntrada();
                    dataGridView1.Rows[index].Cells["dataSaida"].Value = registro.getDataSaida();
                    dataGridView1.Rows[index].Cells["isEstacionado"].Value = "Sim";
                    dataGridView1.Rows[index].Cells["tempoEstacionado"].Value = registro.getTempoEstacionado();
                    dataGridView1.Rows[index].Cells["valorCobrado"].Value = registro.getValorCobrado();
                    dataGridView1.Rows[index].Cells["totalAPagar"].Value = registro.getTotalAPagar();
                }
            }
        }


        private void ButtonRSaida_Click(object sender, EventArgs e)
        {
            FormRegistrarSaida formSaida = new FormRegistrarSaida(listaRegistroEstacionamento);
            if (formSaida.ShowDialog() == DialogResult.OK)
            {




            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            atualizarGridViewEntradas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();

        }

        private void buttonAddTabelaPreco_Click(object sender, EventArgs e)
        {
            FormAddTabelaPrecos formAddTabelaPreco = new FormAddTabelaPrecos();
            if (formAddTabelaPreco.ShowDialog() == DialogResult.OK)
            {




            }
        }

        private void buttonListarSaidas_Click(object sender, EventArgs e)
        {
            atualizarGridViewSaidas();
        }
    }
}
