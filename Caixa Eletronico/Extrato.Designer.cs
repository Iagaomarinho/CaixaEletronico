namespace Caixa_Eletronico
{
    partial class Extrato
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
            DgvExtrato = new DataGridView();
            btVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // DgvExtrato
            // 
            DgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvExtrato.Location = new Point(146, 12);
            DgvExtrato.Name = "DgvExtrato";
            DgvExtrato.Size = new Size(642, 426);
            DgvExtrato.TabIndex = 0;
            DgvExtrato.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Segoe UI", 15F);
            btVoltar.Location = new Point(12, 12);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(114, 57);
            btVoltar.TabIndex = 1;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += button1_Click;
            // 
            // Extrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(DgvExtrato);
            Name = "Extrato";
            Text = "Extrato";
            Load += Extrato_Load;
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvExtrato;
        private Button btVoltar;
    }
}