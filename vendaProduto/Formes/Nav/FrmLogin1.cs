using ErpSigmaVenda.Conexao;
using ErpSigmaVenda.Navegacao;
using ErpSigmaVenda.Persistencia;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    public partial class FrmLogin1 : Form
    {

     
        string tipoUser { get; set; }

        public FrmLogin1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    var adm = new Administrador();
        //    adm.Show();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tipoUser = "Ven";
        }

        private void Administrador_CheckedChanged(object sender, EventArgs e)
        {
            tipoUser = "Adm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = pUsuario.loginUsuario(txtNome.Text, txtSenha.Text);
            var esc = new FrmNavegacaoPrin();
            if(user != null)
            {
                MessageBox.Show("Usuario logado");
                FrmNavegacaoPrin frn = new FrmNavegacaoPrin();
                FrmProduto adm = new FrmProduto();
                frn.oUsuario = user;
                adm.oUsuario = user;
                frn.ShowDialog();
            }
            else { MessageBox.Show("Usuario ou senha inválidos"); }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
