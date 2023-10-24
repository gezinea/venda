using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;
using ErpSigmaVenda.Persistencia;

namespace ErpSigmaVenda.Formes.Nav
{
    public partial class FrmEscolha : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Usuario oUsuario { get; set; }
        public FrmEscolha oEscolhs { get; set; }

        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario oUsuario = pUsuario.ousuario;
            if (oUsuario.tipoUser.Equals("Adm")){
                btFornecedores.Visible = true;
                btUsuario.Visible = true;
                btCliente.Visible = true;
                btProduto.Visible = true;
                imgFornecedores.Visible = true;
                imgCliente.Visible = true;
                imgUsuario.Visible = true;
                imgProduto.Visible = true;
            }
            else
            {
                btCliente.Visible = true;
                imgCliente.Visible = true;
                btProduto.Visible = true;
                imgProduto.Visible = true;
            }
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            var viUser = new FrmUsuario();
            viUser.oUsuario = new Usuario();
            if (viUser.ShowDialog() == DialogResult.OK) {
                db.Usuario.Add(viUser.oUsuario);
                db.SaveChanges();
            }
            

        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            var forn = new FrmFornecedore();
            forn.oFornecedor = new Fornecedores();
            if (forn.ShowDialog()== DialogResult.OK)
            {
                db.Fornecedores.Add(forn.oFornecedor);
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pd = new FrmProduto();
            pd.oProduto = new Produto();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                db.Produto.Add(pd.oProduto);
                db.SaveChanges();
            }
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            var cli = new FrmCliente();
            cli.oCliente = new Cliente();
            if(cli.ShowDialog() == DialogResult.OK)
            {
                db.Cliente.Add(cli.oCliente);
                db.SaveChanges();

            }
        }
    }
}
