namespace GerenciaEstacionamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelFiltroPlaca = new Label();
            buttonBuscarPlaca = new Button();
            textBoxFiltroPlaca = new TextBox();
            buttonAddTabelaPreco = new Button();
            buttonListarGeral = new Button();
            buttonListarSaidas = new Button();
            buttonListarEstacionados = new Button();
            ArqTabelaPreco = new Button();
            ArqEstacionamento = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            placaCarro = new DataGridViewTextBoxColumn();
            dataEntrada = new DataGridViewTextBoxColumn();
            dataSaida = new DataGridViewTextBoxColumn();
            isEstacionado = new DataGridViewTextBoxColumn();
            TempoEstacionado = new DataGridViewTextBoxColumn();
            valorCobrado = new DataGridViewTextBoxColumn();
            totalApagar = new DataGridViewTextBoxColumn();
            LabelBemGuardado = new Label();
            LabelEstacionamento = new Label();
            ButtonRSaida = new Button();
            ButtonREntrada = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(labelFiltroPlaca);
            panel1.Controls.Add(buttonBuscarPlaca);
            panel1.Controls.Add(textBoxFiltroPlaca);
            panel1.Controls.Add(buttonAddTabelaPreco);
            panel1.Controls.Add(buttonListarGeral);
            panel1.Controls.Add(buttonListarSaidas);
            panel1.Controls.Add(buttonListarEstacionados);
            panel1.Controls.Add(ArqTabelaPreco);
            panel1.Controls.Add(ArqEstacionamento);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(LabelBemGuardado);
            panel1.Controls.Add(LabelEstacionamento);
            panel1.Controls.Add(ButtonRSaida);
            panel1.Controls.Add(ButtonREntrada);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 537);
            panel1.TabIndex = 0;
            // 
            // labelFiltroPlaca
            // 
            labelFiltroPlaca.AutoSize = true;
            labelFiltroPlaca.Location = new Point(19, 91);
            labelFiltroPlaca.Name = "labelFiltroPlaca";
            labelFiltroPlaca.Size = new Size(188, 20);
            labelFiltroPlaca.TabIndex = 13;
            labelFiltroPlaca.Text = "Informe a Placa do veículo:";
            // 
            // buttonBuscarPlaca
            // 
            buttonBuscarPlaca.Location = new Point(188, 119);
            buttonBuscarPlaca.Name = "buttonBuscarPlaca";
            buttonBuscarPlaca.Size = new Size(101, 28);
            buttonBuscarPlaca.TabIndex = 12;
            buttonBuscarPlaca.Text = "Buscar Placa";
            buttonBuscarPlaca.UseVisualStyleBackColor = true;
            buttonBuscarPlaca.Click += buttonBuscarPlaca_Click;
            // 
            // textBoxFiltroPlaca
            // 
            textBoxFiltroPlaca.Location = new Point(22, 120);
            textBoxFiltroPlaca.Name = "textBoxFiltroPlaca";
            textBoxFiltroPlaca.Size = new Size(160, 27);
            textBoxFiltroPlaca.TabIndex = 11;
            // 
            // buttonAddTabelaPreco
            // 
            buttonAddTabelaPreco.Location = new Point(902, 109);
            buttonAddTabelaPreco.Name = "buttonAddTabelaPreco";
            buttonAddTabelaPreco.Size = new Size(209, 29);
            buttonAddTabelaPreco.TabIndex = 10;
            buttonAddTabelaPreco.Text = "Adicionar Tebela de Preços";
            buttonAddTabelaPreco.UseVisualStyleBackColor = true;
            buttonAddTabelaPreco.Click += buttonAddTabelaPreco_Click;
            // 
            // buttonListarGeral
            // 
            buttonListarGeral.Location = new Point(22, 455);
            buttonListarGeral.Name = "buttonListarGeral";
            buttonListarGeral.Size = new Size(154, 50);
            buttonListarGeral.TabIndex = 9;
            buttonListarGeral.Text = "Listar Tudo";
            buttonListarGeral.UseVisualStyleBackColor = true;
            buttonListarGeral.Click += button3_Click;
            // 
            // buttonListarSaidas
            // 
            buttonListarSaidas.ForeColor = Color.Red;
            buttonListarSaidas.Location = new Point(351, 455);
            buttonListarSaidas.Name = "buttonListarSaidas";
            buttonListarSaidas.Size = new Size(154, 50);
            buttonListarSaidas.TabIndex = 8;
            buttonListarSaidas.Text = "Listar Saídas";
            buttonListarSaidas.UseVisualStyleBackColor = true;
            buttonListarSaidas.Click += buttonListarSaidas_Click;
            // 
            // buttonListarEstacionados
            // 
            buttonListarEstacionados.ForeColor = Color.MediumSeaGreen;
            buttonListarEstacionados.Location = new Point(182, 455);
            buttonListarEstacionados.Name = "buttonListarEstacionados";
            buttonListarEstacionados.Size = new Size(154, 50);
            buttonListarEstacionados.TabIndex = 7;
            buttonListarEstacionados.Text = "Listar Carros Estacionados";
            buttonListarEstacionados.UseVisualStyleBackColor = true;
            buttonListarEstacionados.Click += button1_Click_2;
            // 
            // ArqTabelaPreco
            // 
            ArqTabelaPreco.Location = new Point(865, 68);
            ArqTabelaPreco.Name = "ArqTabelaPreco";
            ArqTabelaPreco.Size = new Size(278, 29);
            ArqTabelaPreco.TabIndex = 6;
            ArqTabelaPreco.Text = "Selecionar Arquivo de Tabelas de Preço";
            ArqTabelaPreco.UseVisualStyleBackColor = true;
            ArqTabelaPreco.Click += ArqTabelaPreco_Click;
            // 
            // ArqEstacionamento
            // 
            ArqEstacionamento.Location = new Point(865, 29);
            ArqEstacionamento.Name = "ArqEstacionamento";
            ArqEstacionamento.Size = new Size(278, 29);
            ArqEstacionamento.TabIndex = 5;
            ArqEstacionamento.Text = "Selecionar Arquivo Estacionamento";
            ArqEstacionamento.UseVisualStyleBackColor = true;
            ArqEstacionamento.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, placaCarro, dataEntrada, dataSaida, isEstacionado, TempoEstacionado, valorCobrado, totalApagar });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Location = new Point(22, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1121, 278);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F);
            ID.DefaultCellStyle = dataGridViewCellStyle8;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // placaCarro
            // 
            placaCarro.HeaderText = "Placa";
            placaCarro.MinimumWidth = 6;
            placaCarro.Name = "placaCarro";
            placaCarro.Width = 132;
            // 
            // dataEntrada
            // 
            dataEntrada.HeaderText = "Hora Entrada";
            dataEntrada.MinimumWidth = 6;
            dataEntrada.Name = "dataEntrada";
            dataEntrada.Width = 132;
            // 
            // dataSaida
            // 
            dataSaida.HeaderText = "Hora Saída";
            dataSaida.MinimumWidth = 6;
            dataSaida.Name = "dataSaida";
            dataSaida.Width = 132;
            // 
            // isEstacionado
            // 
            isEstacionado.HeaderText = "Está Estacionado?";
            isEstacionado.MinimumWidth = 6;
            isEstacionado.Name = "isEstacionado";
            isEstacionado.Width = 140;
            // 
            // TempoEstacionado
            // 
            TempoEstacionado.HeaderText = "Tempo Estacionado";
            TempoEstacionado.MinimumWidth = 6;
            TempoEstacionado.Name = "TempoEstacionado";
            TempoEstacionado.Width = 143;
            // 
            // valorCobrado
            // 
            valorCobrado.HeaderText = "Valor Total";
            valorCobrado.MinimumWidth = 6;
            valorCobrado.Name = "valorCobrado";
            valorCobrado.Width = 132;
            // 
            // totalApagar
            // 
            totalApagar.HeaderText = "Valor a Pagar";
            totalApagar.MinimumWidth = 6;
            totalApagar.Name = "totalApagar";
            totalApagar.Width = 132;
            // 
            // LabelBemGuardado
            // 
            LabelBemGuardado.AutoSize = true;
            LabelBemGuardado.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBemGuardado.ForeColor = SystemColors.MenuHighlight;
            LabelBemGuardado.Location = new Point(19, 41);
            LabelBemGuardado.Name = "LabelBemGuardado";
            LabelBemGuardado.Size = new Size(315, 41);
            LabelBemGuardado.TabIndex = 3;
            LabelBemGuardado.Text = "Carro Bem Guardado";
            LabelBemGuardado.Click += label2_Click;
            // 
            // LabelEstacionamento
            // 
            LabelEstacionamento.AutoSize = true;
            LabelEstacionamento.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstacionamento.Location = new Point(19, 10);
            LabelEstacionamento.Name = "LabelEstacionamento";
            LabelEstacionamento.Size = new Size(191, 31);
            LabelEstacionamento.TabIndex = 2;
            LabelEstacionamento.Text = "Estacionamento";
            LabelEstacionamento.Click += label1_Click;
            // 
            // ButtonRSaida
            // 
            ButtonRSaida.ForeColor = Color.Red;
            ButtonRSaida.Location = new Point(986, 460);
            ButtonRSaida.Name = "ButtonRSaida";
            ButtonRSaida.Size = new Size(157, 50);
            ButtonRSaida.TabIndex = 1;
            ButtonRSaida.Text = "Registrar Saída";
            ButtonRSaida.UseVisualStyleBackColor = true;
            ButtonRSaida.Click += ButtonRSaida_Click;
            // 
            // ButtonREntrada
            // 
            ButtonREntrada.ForeColor = Color.MediumSeaGreen;
            ButtonREntrada.Location = new Point(823, 460);
            ButtonREntrada.Name = "ButtonREntrada";
            ButtonREntrada.Size = new Size(157, 50);
            ButtonREntrada.TabIndex = 0;
            ButtonREntrada.Text = "Registrar Entrada";
            ButtonREntrada.UseVisualStyleBackColor = true;
            ButtonREntrada.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 536);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ButtonREntrada;
        private Label LabelEstacionamento;
        private Button ButtonRSaida;
        private Label LabelBemGuardado;
        private DataGridView dataGridView1;
        private Button ArqTabelaPreco;
        private Button ArqEstacionamento;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn placaCarro;
        private DataGridViewTextBoxColumn dataEntrada;
        private DataGridViewTextBoxColumn dataSaida;
        private DataGridViewTextBoxColumn isEstacionado;
        private DataGridViewTextBoxColumn TempoEstacionado;
        private DataGridViewTextBoxColumn valorCobrado;
        private DataGridViewTextBoxColumn totalApagar;
        private Button buttonAddTabelaPreco;
        private Button buttonListarGeral;
        private Button buttonListarSaidas;
        private Button buttonListarEstacionados;
        private Label labelFiltroPlaca;
        private Button buttonBuscarPlaca;
        private TextBox textBoxFiltroPlaca;
    }
}
