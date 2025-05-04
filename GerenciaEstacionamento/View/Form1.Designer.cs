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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panel1 = new Panel();
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
            buttonListarEstacionados = new Button();
            buttonListarSaidas = new Button();
            buttonListarGeral = new Button();
            buttonAddTabelaPreco = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
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
            panel1.Size = new Size(1173, 445);
            panel1.TabIndex = 0;
            // 
            // ArqTabelaPreco
            // 
            ArqTabelaPreco.Location = new Point(22, 121);
            ArqTabelaPreco.Name = "ArqTabelaPreco";
            ArqTabelaPreco.Size = new Size(335, 29);
            ArqTabelaPreco.TabIndex = 6;
            ArqTabelaPreco.Text = "Selecionar Arquivo de Tabelas de Preço";
            ArqTabelaPreco.UseVisualStyleBackColor = true;
            ArqTabelaPreco.Click += ArqTabelaPreco_Click;
            // 
            // ArqEstacionamento
            // 
            ArqEstacionamento.Location = new Point(22, 89);
            ArqEstacionamento.Name = "ArqEstacionamento";
            ArqEstacionamento.Size = new Size(335, 29);
            ArqEstacionamento.TabIndex = 5;
            ArqEstacionamento.Text = "Selecionar Arquivo Estacionamento";
            ArqEstacionamento.UseVisualStyleBackColor = true;
            ArqEstacionamento.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, placaCarro, dataEntrada, dataSaida, isEstacionado, TempoEstacionado, valorCobrado, totalApagar });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Location = new Point(22, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1121, 278);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F);
            ID.DefaultCellStyle = dataGridViewCellStyle13;
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
            LabelBemGuardado.Location = new Point(42, 41);
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
            ButtonRSaida.Location = new Point(989, 89);
            ButtonRSaida.Name = "ButtonRSaida";
            ButtonRSaida.Size = new Size(154, 50);
            ButtonRSaida.TabIndex = 1;
            ButtonRSaida.Text = "Registrar Saída";
            ButtonRSaida.UseVisualStyleBackColor = true;
            ButtonRSaida.Click += ButtonRSaida_Click;
            // 
            // ButtonREntrada
            // 
            ButtonREntrada.ForeColor = Color.MediumSeaGreen;
            ButtonREntrada.Location = new Point(989, 33);
            ButtonREntrada.Name = "ButtonREntrada";
            ButtonREntrada.Size = new Size(154, 50);
            ButtonREntrada.TabIndex = 0;
            ButtonREntrada.Text = "Registrar Entrada";
            ButtonREntrada.UseVisualStyleBackColor = true;
            ButtonREntrada.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonListarEstacionados
            // 
            buttonListarEstacionados.ForeColor = Color.MediumSeaGreen;
            buttonListarEstacionados.Location = new Point(815, 33);
            buttonListarEstacionados.Name = "buttonListarEstacionados";
            buttonListarEstacionados.Size = new Size(154, 50);
            buttonListarEstacionados.TabIndex = 7;
            buttonListarEstacionados.Text = "Listar Carros Estacionados";
            buttonListarEstacionados.UseVisualStyleBackColor = true;
            buttonListarEstacionados.Click += button1_Click_2;
            // 
            // buttonListarSaidas
            // 
            buttonListarSaidas.ForeColor = Color.Red;
            buttonListarSaidas.Location = new Point(814, 89);
            buttonListarSaidas.Name = "buttonListarSaidas";
            buttonListarSaidas.Size = new Size(154, 50);
            buttonListarSaidas.TabIndex = 8;
            buttonListarSaidas.Text = "Listar Saídas";
            buttonListarSaidas.UseVisualStyleBackColor = true;
            // 
            // buttonListarGeral
            // 
            buttonListarGeral.Location = new Point(655, 58);
            buttonListarGeral.Name = "buttonListarGeral";
            buttonListarGeral.Size = new Size(154, 49);
            buttonListarGeral.TabIndex = 9;
            buttonListarGeral.Text = "Listar Geral";
            buttonListarGeral.UseVisualStyleBackColor = true;
            buttonListarGeral.Click += this.button3_Click;
            // 
            // buttonAddTabelaPreco
            // 
            buttonAddTabelaPreco.Location = new Point(363, 121);
            buttonAddTabelaPreco.Name = "buttonAddTabelaPreco";
            buttonAddTabelaPreco.Size = new Size(209, 29);
            buttonAddTabelaPreco.TabIndex = 10;
            buttonAddTabelaPreco.Text = "Adicionar Tebela de Preços";
            buttonAddTabelaPreco.UseVisualStyleBackColor = true;
            buttonAddTabelaPreco.Click += buttonAddTabelaPreco_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 444);
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
    }
}
