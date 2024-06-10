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
    public partial class frmTelaPrincipal : Form
    {
        Singleton s;
        public frmTelaPrincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicial frm = new FrmInicial();
            frm.Show();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOperacao frm = new frmOperacao('d');
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extrato frm = new Extrato();
            frm.Show();
            this.Hide();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            frmOperacao frm = new frmOperacao('s');
            frm.Show();
            this.Hide();
        }

        private void btTransf_Click(object sender, EventArgs e)
        {
            frmOperacao frm = new frmOperacao('t');
            frm.Show();
            this.Hide();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            lblS.Text = s.logada.Saldo.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
