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
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // DgvExtrato
            // 
            DgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvExtrato.Location = new Point(80, 12);
            DgvExtrato.Name = "DgvExtrato";
            DgvExtrato.Size = new Size(603, 322);
            DgvExtrato.TabIndex = 0;
            DgvExtrato.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Extrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvExtrato);
            Name = "Extrato";
            Text = "Extrato";
            Load += Extrato_Load;
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvExtrato;
    }
}