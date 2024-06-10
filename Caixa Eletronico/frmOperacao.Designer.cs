namespace Caixa_Eletronico
{
    partial class frmOperacao
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
            lblOperacao = new Label();
            lblValor = new Label();
            numValor = new NumericUpDown();
            btRealizar = new Button();
            num_conta = new TextBox();
            lblConta = new Label();
            btVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Segoe UI", 18F);
            lblOperacao.Location = new Point(296, 43);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 32);
            lblOperacao.TabIndex = 0;
            lblOperacao.Click += lblOperacao_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 14F);
            lblValor.Location = new Point(236, 108);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(65, 25);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor: ";
            // 
            // numValor
            // 
            numValor.Font = new Font("Segoe UI", 12F);
            numValor.Location = new Point(307, 108);
            numValor.Name = "numValor";
            numValor.Size = new Size(181, 29);
            numValor.TabIndex = 2;
            numValor.ValueChanged += numValor_ValueChanged;
            // 
            // btRealizar
            // 
            btRealizar.Font = new Font("Segoe UI", 13F);
            btRealizar.Location = new Point(307, 210);
            btRealizar.Name = "btRealizar";
            btRealizar.Size = new Size(181, 47);
            btRealizar.TabIndex = 3;
            btRealizar.Text = "Realizar";
            btRealizar.UseVisualStyleBackColor = true;
            btRealizar.Click += btRealizar_Click;
            // 
            // num_conta
            // 
            num_conta.Location = new Point(307, 150);
            num_conta.Name = "num_conta";
            num_conta.Size = new Size(181, 23);
            num_conta.TabIndex = 4;
            num_conta.Visible = false;
            num_conta.TextChanged += textBox1_TextChanged;
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Font = new Font("Segoe UI", 14F);
            lblConta.Location = new Point(65, 145);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(236, 25);
            lblConta.TabIndex = 5;
            lblConta.Text = "Conta que deseja tranferir:";
            lblConta.Visible = false;
            lblConta.Click += label1_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(53, 36);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(101, 39);
            btVoltar.TabIndex = 6;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += button1_Click;
            // 
            // frmOperacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(lblConta);
            Controls.Add(num_conta);
            Controls.Add(btRealizar);
            Controls.Add(numValor);
            Controls.Add(lblValor);
            Controls.Add(lblOperacao);
            Name = "frmOperacao";
            Text = "Tela de Operações";
            Load += frmOperacao_Load;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperacao;
        private Label lblValor;
        private NumericUpDown numValor;
        private Button btRealizar;
        private TextBox num_conta;
        private Label lblConta;
        private Button btVoltar;
    }
}