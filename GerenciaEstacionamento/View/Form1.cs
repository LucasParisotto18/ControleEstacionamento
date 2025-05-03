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
    }
}
