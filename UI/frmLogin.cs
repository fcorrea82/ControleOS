using System;
using ControleOSPRF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ControleOSPRF
{
    public partial class frmLogin : Form
    {
      
        public frmLogin()
        {
            // Thread t = new Thread(new ThreadStart(StartForm));
            // t.Start();
            // Thread.Sleep(5000);
            InitializeComponent();
        }


        public void StartForm() 
        {
            Application.Run(new frmLogin());
        }
        

        

    void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblDataHoraAtual.Text = DateTime.Now.ToString();
        }

        private void tmrDataHoraLocal_Tick(object sender, EventArgs e)
        {
            lblDataHoraAtual.Text = DateTime.Now.ToString();
        }

        private void btnFecharAplicacao_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fechar totalmente a aplicação
        }

        private void btnMinimizarFrmLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
