namespace GerenciaEstacionamento.View
{
    partial class FormAddTabelaPrecos
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
            label1 = new Label();
            labelDataInicioVigencia = new Label();
            labelDataFimVigencia = new Label();
            labelCustoInicial = new Label();
            label2 = new Label();
            textBoxInicioVigencia = new TextBox();
            textBoxCustoInicial = new TextBox();
            textBoxFimVigencia = new TextBox();
            textBoxCustoAdicional = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1HoraAtual = new Button();
            button2HoraAtual = new Button();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 0;
            label1.Text = "Adicionar nova tabela de Preços";
            // 
            // labelDataInicioVigencia
            // 
            labelDataInicioVigencia.AutoSize = true;
            labelDataInicioVigencia.Location = new Point(33, 75);
            labelDataInicioVigencia.Name = "labelDataInicioVigencia";
            labelDataInicioVigencia.Size = new Size(251, 20);
            labelDataInicioVigencia.TabIndex = 1;
            labelDataInicioVigencia.Text = "Informe a data de inicio da vigência:";
            labelDataInicioVigencia.Click += label2_Click;
            // 
            // labelDataFimVigencia
            // 
            labelDataFimVigencia.AutoSize = true;
            labelDataFimVigencia.Location = new Point(33, 183);
            labelDataFimVigencia.Name = "labelDataFimVigencia";
            labelDataFimVigencia.Size = new Size(238, 20);
            labelDataFimVigencia.TabIndex = 2;
            labelDataFimVigencia.Text = "Informe a data do fim da vigência:";
            // 
            // labelCustoInicial
            // 
            labelCustoInicial.AutoSize = true;
            labelCustoInicial.Location = new Point(32, 285);
            labelCustoInicial.Name = "labelCustoInicial";
            labelCustoInicial.Size = new Size(214, 20);
            labelCustoInicial.TabIndex = 3;
            labelCustoInicial.Text = "Informe o custo da hora inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 365);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 4;
            label2.Text = "Informe o custo da hora adicional:";
            // 
            // textBoxInicioVigencia
            // 
            textBoxInicioVigencia.Location = new Point(33, 105);
            textBoxInicioVigencia.Name = "textBoxInicioVigencia";
            textBoxInicioVigencia.Size = new Size(247, 27);
            textBoxInicioVigencia.TabIndex = 5;
            // 
            // textBoxCustoInicial
            // 
            textBoxCustoInicial.Location = new Point(32, 310);
            textBoxCustoInicial.Name = "textBoxCustoInicial";
            textBoxCustoInicial.Size = new Size(247, 27);
            textBoxCustoInicial.TabIndex = 6;
            // 
            // textBoxFimVigencia
            // 
            textBoxFimVigencia.Location = new Point(32, 212);
            textBoxFimVigencia.Name = "textBoxFimVigencia";
            textBoxFimVigencia.Size = new Size(247, 27);
            textBoxFimVigencia.TabIndex = 7;
            // 
            // textBoxCustoAdicional
            // 
            textBoxCustoAdicional.Location = new Point(31, 393);
            textBoxCustoAdicional.Name = "textBoxCustoAdicional";
            textBoxCustoAdicional.Size = new Size(247, 27);
            textBoxCustoAdicional.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(246, 17);
            label3.TabIndex = 9;
            label3.Text = "Formato esperado: dd/MM/yyyy HH:mm:ss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 243);
            label4.Name = "label4";
            label4.Size = new Size(246, 17);
            label4.TabIndex = 10;
            label4.Text = "Formato esperado: dd/MM/yyyy HH:mm:ss";
            // 
            // button1HoraAtual
            // 
            button1HoraAtual.Location = new Point(297, 105);
            button1HoraAtual.Name = "button1HoraAtual";
            button1HoraAtual.Size = new Size(94, 29);
            button1HoraAtual.TabIndex = 11;
            button1HoraAtual.Text = "Hora Atual";
            button1HoraAtual.UseVisualStyleBackColor = true;
            button1HoraAtual.Click += button1HoraAtual_Click;
            // 
            // button2HoraAtual
            // 
            button2HoraAtual.Location = new Point(297, 210);
            button2HoraAtual.Name = "button2HoraAtual";
            button2HoraAtual.Size = new Size(94, 29);
            button2HoraAtual.TabIndex = 12;
            button2HoraAtual.Text = "Hora Atual";
            button2HoraAtual.UseVisualStyleBackColor = true;
            button2HoraAtual.Click += button2HoraAtual_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(372, 391);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(131, 47);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(520, 391);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(131, 47);
            buttonConfirmar.TabIndex = 14;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // FormAddTabelaPrecos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(buttonConfirmar);
            Controls.Add(buttonCancelar);
            Controls.Add(button2HoraAtual);
            Controls.Add(button1HoraAtual);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxCustoAdicional);
            Controls.Add(textBoxFimVigencia);
            Controls.Add(textBoxCustoInicial);
            Controls.Add(textBoxInicioVigencia);
            Controls.Add(label2);
            Controls.Add(labelCustoInicial);
            Controls.Add(labelDataFimVigencia);
            Controls.Add(labelDataInicioVigencia);
            Controls.Add(label1);
            Name = "FormAddTabelaPrecos";
            Text = "FormAddTabelaPrecos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelDataInicioVigencia;
        private Label labelDataFimVigencia;
        private Label labelCustoInicial;
        private Label label2;
        private TextBox textBoxInicioVigencia;
        private TextBox textBoxCustoInicial;
        private TextBox textBoxFimVigencia;
        private TextBox textBoxCustoAdicional;
        private Label label3;
        private Label label4;
        private Button button1HoraAtual;
        private Button button2HoraAtual;
        private Button buttonCancelar;
        private Button buttonConfirmar;
    }
}