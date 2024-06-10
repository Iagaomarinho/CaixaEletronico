        namespace Caixa_Eletronico
{
    partial class frmTelaPrincipal
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
            btVoltar = new Button();
            lblSaldo = new Label();
            panel1 = new Panel();
            lblS = new Label();
            btVerExtrat = new Button();
            btTransf = new Button();
            btDeposita = new Button();
            btSacar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(17, 18);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(116, 46);
            btVoltar.TabIndex = 0;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += button1_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(496, 25);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 22);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo: ";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblS);
            panel1.Controls.Add(btVerExtrat);
            panel1.Controls.Add(btTransf);
            panel1.Controls.Add(btDeposita);
            panel1.Controls.Add(btSacar);
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(btVoltar);
            panel1.Location = new Point(39, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 369);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Location = new Point(571, 31);
            lblS.Name = "lblS";
            lblS.Size = new Size(0, 15);
            lblS.TabIndex = 6;
            // 
            // btVerExtrat
            // 
            btVerExtrat.Font = new Font("Segoe UI", 12F);
            btVerExtrat.Location = new Point(206, 299);
            btVerExtrat.Name = "btVerExtrat";
            btVerExtrat.Size = new Size(322, 55);
            btVerExtrat.TabIndex = 5;
            btVerExtrat.Text = "Ver Extrato";
            btVerExtrat.UseVisualStyleBackColor = true;
            btVerExtrat.Click += button4_Click;
            // 
            // btTransf
            // 
            btTransf.Font = new Font("Segoe UI", 12F);
            btTransf.Location = new Point(206, 238);
            btTransf.Name = "btTransf";
            btTransf.Size = new Size(322, 55);
            btTransf.TabIndex = 4;
            btTransf.Text = "Transferir";
            btTransf.UseVisualStyleBackColor = true;
            btTransf.Click += btTransf_Click;
            // 
            // btDeposita
            // 
            btDeposita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDeposita.Location = new Point(206, 116);
            btDeposita.Name = "btDeposita";
            btDeposita.Size = new Size(322, 55);
            btDeposita.TabIndex = 3;
            btDeposita.Text = "Depositar";
            btDeposita.UseVisualStyleBackColor = true;
            btDeposita.Click += button2_Click;
            // 
            // btSacar
            // 
            btSacar.Font = new Font("Segoe UI", 12F);
            btSacar.Location = new Point(206, 177);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(322, 55);
            btSacar.TabIndex = 2;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = true;
            btSacar.Click += btSacar_Click;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmTelaPrincipal";
            Text = "frmTelaPrincipal";
            Load += frmTelaPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btVoltar;
        private Label lblSaldo;
        private Panel panel1;
        private Button btVerExtrat;
        private Button btTransf;
        private Button btDeposita;
        private Button btSacar;
        private Label lblS;
    }
}