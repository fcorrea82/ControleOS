using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleOSPRF
{
    public partial class FrmOS : Form
    {
        public FrmOS()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP1.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {

                 try
                    {
                        var endereco = ws.consultaCEP(txtCEP1.Text.Trim());

                        txtLogradouro.Text = endereco.end;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.cidade;
                        txtEstado.Text = endereco.uf;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Informe o CEP Válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Salvar Registro");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "Fechar");
        }
    }
}
