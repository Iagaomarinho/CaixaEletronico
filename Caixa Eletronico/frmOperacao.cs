using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caixa_Eletronico
{
    public partial class frmOperacao : Form
    {
        char operacao;
        Singleton s;

        public frmOperacao(char tipo) : this()
        {
            this.operacao = tipo;
        }
        public frmOperacao()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btRealizar_Click(object sender, EventArgs e)
        {
            double valor = (double)numValor.Value;
            switch (this.operacao)
            {
                case 's':
                    s.logada.Sacar(valor);
                    if(s.logada.Sacar(valor)){
                        MessageBox.Show("Saque Realizado");
                    }
                    break;
                case 'd':
                    if (s.logada.Depositar(valor))
                    {
                        MessageBox.Show("Depósito Realizado");
                    }
                    break;
                case 't':
                    Conta destino = s.BuscarConta(num_conta.Text);
                    if (destino != null)
                    {
                        if (s.logada.Transferir(destino, valor))
                        {
                            MessageBox.Show("Tranferência Realizada");
                        }
                        else
                        {
                            MessageBox.Show("Algo deu errado, Tente Novamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Conta não encontrada");
                    }
                    break;
                case 'e':
                    Extrato frm2 = new Extrato();
                    frm2.Show();
                    this.Hide();
                    break;
            }
            frmTelaPrincipal frm = new frmTelaPrincipal();
            frm.Show();
            this.Hide();
        }

        private void frmOperacao_Load(object sender, EventArgs e)
        {
            switch (this.operacao)
            {
                case 's':
                    lblOperacao.Text = "Sacar";
                    break;
                case 'd':
                    lblOperacao.Text = "Depositar";
                    break;
                case 't':
                    lblOperacao.Text = "Transferir";
                    num_conta.Visible = true;
                    lblConta.Visible = true;
                    break;
                case 'e':
                    lblOperacao.Text = "Ver extrato";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.operacao == 't')
            {
                Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = Singleton.Instance;
            this.operacao = operacao;
            if (this.operacao == 't')
            {
                Visible = true;
            }
        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frm = new frmTelaPrincipal();
            frm.Show();
            this.Hide();

            
        }
    }
}
