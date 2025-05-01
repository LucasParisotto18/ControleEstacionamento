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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            HoraSaida = new DataGridViewTextBoxColumn();
            isEstacionado = new DataGridViewTextBoxColumn();
            TempoEstacionado = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            ValorPagar = new DataGridViewTextBoxColumn();
            LabelBemGuardado = new Label();
            LabelEstacionamento = new Label();
            ButtonRSaida = new Button();
            ButtonREntrada = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
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
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Placa, HoraEntrada, HoraSaida, isEstacionado, TempoEstacionado, valorTotal, ValorPagar });
            dataGridView1.Location = new Point(22, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1121, 273);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.MinimumWidth = 6;
            Placa.Name = "Placa";
            Placa.Width = 132;
            // 
            // HoraEntrada
            // 
            HoraEntrada.HeaderText = "Hora Entrada";
            HoraEntrada.MinimumWidth = 6;
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.Width = 132;
            // 
            // HoraSaida
            // 
            HoraSaida.HeaderText = "Hora Saída";
            HoraSaida.MinimumWidth = 6;
            HoraSaida.Name = "HoraSaida";
            HoraSaida.Width = 132;
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
            // valorTotal
            // 
            valorTotal.HeaderText = "Valor Total";
            valorTotal.MinimumWidth = 6;
            valorTotal.Name = "valorTotal";
            valorTotal.Width = 132;
            // 
            // ValorPagar
            // 
            ValorPagar.HeaderText = "Valor a Pagar";
            ValorPagar.MinimumWidth = 6;
            ValorPagar.Name = "ValorPagar";
            ValorPagar.Width = 132;
            // 
            // LabelBemGuardado
            // 
            LabelBemGuardado.AutoSize = true;
            LabelBemGuardado.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBemGuardado.ForeColor = SystemColors.MenuHighlight;
            LabelBemGuardado.Location = new Point(220, 65);
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
            LabelEstacionamento.Location = new Point(220, 37);
            LabelEstacionamento.Name = "LabelEstacionamento";
            LabelEstacionamento.Size = new Size(191, 31);
            LabelEstacionamento.TabIndex = 2;
            LabelEstacionamento.Text = "Estacionamento";
            LabelEstacionamento.Click += label1_Click;
            // 
            // ButtonRSaida
            // 
            ButtonRSaida.ForeColor = Color.Red;
            ButtonRSaida.Location = new Point(960, 46);
            ButtonRSaida.Name = "ButtonRSaida";
            ButtonRSaida.Size = new Size(183, 50);
            ButtonRSaida.TabIndex = 1;
            ButtonRSaida.Text = "Registrar Saída";
            ButtonRSaida.UseVisualStyleBackColor = true;
            // 
            // ButtonREntrada
            // 
            ButtonREntrada.ForeColor = Color.MediumSeaGreen;
            ButtonREntrada.Location = new Point(735, 46);
            ButtonREntrada.Name = "ButtonREntrada";
            ButtonREntrada.Size = new Size(193, 50);
            ButtonREntrada.TabIndex = 0;
            ButtonREntrada.Text = "Registrar Entrada";
            ButtonREntrada.UseVisualStyleBackColor = true;
            ButtonREntrada.Click += button1_Click;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn HoraSaida;
        private DataGridViewTextBoxColumn isEstacionado;
        private DataGridViewTextBoxColumn TempoEstacionado;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn ValorPagar;
    }
}
