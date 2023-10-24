using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda.Navegacao
{
    public partial class FrmNavegacaoPrin : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Usuario oUsuario { get; set; }

        public FrmNavegacaoPrin()
        {
            InitializeComponent();
        }

        private void NavegacaoPrin_Load(object sender, EventArgs e)
        {

        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            var cad = new FrmEscolha();
            if (cad.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
            }
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            var ven = new FrmVenda();
       
            if(ven.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
            }
        }
    }
}
