namespace GerenciaEstacionamento.View
{
    partial class FormRegistrarSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            placaCarro = new DataGridViewTextBoxColumn();
            dataEntrada = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            textBoxHorario = new TextBox();
            label4 = new Label();
            buttonHorarioArtual = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(643, 420);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(122, 48);
            buttonCancelar.TabIndex = 0;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(780, 420);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(123, 48);
            buttonConfirmar.TabIndex = 1;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Registrar Saída";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, placaCarro, dataEntrada });
            dataGridView1.Location = new Point(21, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(509, 227);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 140;
            // 
            // placaCarro
            // 
            placaCarro.HeaderText = "Placa";
            placaCarro.MinimumWidth = 6;
            placaCarro.Name = "placaCarro";
            placaCarro.Width = 150;
            // 
            // dataEntrada
            // 
            dataEntrada.HeaderText = "Horário de entrada";
            dataEntrada.MinimumWidth = 6;
            dataEntrada.Name = "dataEntrada";
            dataEntrada.Width = 166;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 4;
            label2.Text = "Selecione o carro para registrar a Saída:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 338);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 5;
            label3.Text = "Informe o horário de saída:";
            // 
            // textBoxHorario
            // 
            textBoxHorario.Location = new Point(23, 378);
            textBoxHorario.Name = "textBoxHorario";
            textBoxHorario.Size = new Size(341, 27);
            textBoxHorario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 411);
            label4.Name = "label4";
            label4.Size = new Size(246, 17);
            label4.TabIndex = 7;
            label4.Text = "Formato esperado: dd/MM/yyyy HH:mm:ss";
            // 
            // buttonHorarioArtual
            // 
            buttonHorarioArtual.Location = new Point(405, 376);
            buttonHorarioArtual.Name = "buttonHorarioArtual";
            buttonHorarioArtual.Size = new Size(125, 29);
            buttonHorarioArtual.TabIndex = 8;
            buttonHorarioArtual.Text = "Hora Atual";
            buttonHorarioArtual.UseVisualStyleBackColor = true;
            buttonHorarioArtual.Click += button1_Click;
            // 
            // FormRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 477);
            Controls.Add(buttonHorarioArtual);
            Controls.Add(label4);
            Controls.Add(textBoxHorario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(buttonConfirmar);
            Controls.Add(buttonCancelar);
            Name = "FormRegistrarSaida";
            Text = "FormRegistrarSaida";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonConfirmar;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBoxHorario;
        private Label label4;
        private Button buttonHorarioArtual;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn placaCarro;
        private DataGridViewTextBoxColumn dataEntrada;
    }
}