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
        Conta c;
        public frmOperacao(Conta c, char operacao)
        {
            InitializeComponent();
            s = Singleton.Instance;
            this.operacao = operacao;
            this.c = c;    
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
                    break;
                case 'e':
                    lblOperacao.Text = "Ver extrato";
                    break;

            }
        }

        private void btRealizar_Click(object sender, EventArgs e)
        {
            double valor = (double)numValor.Value;
            switch (this.operacao)
            {
                case 's':
                    s.logada.Sacar(valor);
                    break;
                case 'd':
                    s.logada.Depositar(valor);
                    break;
                case 't':
                    s.logada.Transferir(c, valor);
                    break;
                case 'e':
                    ;
                    break;
            }
        }

        private void frmOperacao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(this.operacao == 't')
            {
                Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
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
    }
}
