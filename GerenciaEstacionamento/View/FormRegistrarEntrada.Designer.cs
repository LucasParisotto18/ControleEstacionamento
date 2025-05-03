namespace GerenciaEstacionamento.View
{
    partial class FormRegistrarEntrada
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
            label2 = new Label();
            label3 = new Label();
            textBoxPlaca = new TextBox();
            textBoxData = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(363, 386);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(161, 52);
            buttonCancelar.TabIndex = 0;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(558, 386);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(161, 52);
            buttonConfirmar.TabIndex = 1;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 2;
            label1.Text = "Registrar Nova Entrada";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 114);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Placa do Veículo:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 214);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 4;
            label3.Text = "Data e Hora de Entrada:";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(24, 150);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(393, 27);
            textBoxPlaca.TabIndex = 5;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(24, 264);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(393, 27);
            textBoxData.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 299);
            label4.Name = "label4";
            label4.Size = new Size(246, 17);
            label4.TabIndex = 7;
            label4.Text = "Formato esperado: dd/MM/yyyy HH:mm:ss";
            label4.Click += label4_Click;
            // 
            // FormRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
            Controls.Add(label4);
            Controls.Add(textBoxData);
            Controls.Add(textBoxPlaca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConfirmar);
            Controls.Add(buttonCancelar);
            Name = "FormRegistrarEntrada";
            Text = "FormRegistrarEntrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPlaca;
        private TextBox textBoxData;
        private Label label4;
    }
}