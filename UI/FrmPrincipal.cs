using ControleOSPRF;
using ControleOSPRF.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOS frmOS = new FrmOS();
            frmOS.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOS frmOS = new FrmOS();
            frmOS.ShowDialog();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox3, "Fechar Programa");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Cadastrar Ordem de Serviço");
        }

        private void tiposDeSolicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSolicitacao frmSolicitacao = new FrmSolicitacao();
            frmSolicitacao.ShowDialog();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString();
        }

        private void tmrHoraAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }
    }
}
