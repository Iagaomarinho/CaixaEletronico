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

namespace Caixa_Eletronico
{
    public partial class frmLogin : Form
    {
        Singleton s;
        public frmLogin()
        {
            s = Singleton.Instance;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtLogin.Text);
            if (c != null)
            {
                //logado
                s.logada = c;
                frmTelaPrincipal frm = new frmTelaPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
                //nao achou
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
