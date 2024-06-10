namespace Caixa_Eletronico
{
    partial class frmLogin
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
            btAcessar = new Button();
            txtLogin = new TextBox();
            label1 = new Label();
            bt_voltar = new Button();
            SuspendLayout();
            // 
            // btAcessar
            // 
            btAcessar.Font = new Font("Segoe UI", 15F);
            btAcessar.Location = new Point(378, 144);
            btAcessar.Name = "btAcessar";
            btAcessar.Size = new Size(90, 35);
            btAcessar.TabIndex = 0;
            btAcessar.Text = "Acessar";
            btAcessar.UseVisualStyleBackColor = true;
            btAcessar.Click += btAcessar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(296, 93);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(300, 23);
            txtLogin.TabIndex = 1;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(208, 84);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 2;
            label1.Text = "Conta:";
            label1.Click += label1_Click;
            // 
            // bt_voltar
            // 
            bt_voltar.Font = new Font("Segoe UI", 15F);
            bt_voltar.Location = new Point(26, 31);
            bt_voltar.Name = "bt_voltar";
            bt_voltar.Size = new Size(99, 41);
            bt_voltar.TabIndex = 3;
            bt_voltar.Text = "Voltar";
            bt_voltar.UseVisualStyleBackColor = true;
            bt_voltar.Click += button1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_voltar);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(btAcessar);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAcessar;
        private TextBox txtLogin;
        private Label label1;
        private Button bt_voltar;
    }
}