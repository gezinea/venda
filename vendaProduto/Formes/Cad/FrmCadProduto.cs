using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda.Formes.Cad
{
    public partial class FrmCadProduto : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();

        public Produto oProduto { get; set; }
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void cadProduto_Load(object sender, EventArgs e)
        {
            loading();
        }

        public void loading()
        {
            this.txtNomeP.Text = this.oProduto.Nome;
            this.txtDescricao.Text = this.oProduto.Descricao;
            this.txtPreco.Text = this.oProduto.Preco.ToString();
            this.txtQntEstoque.Text = this.oProduto.QntEstoque.ToString();
        }

        private void update()
        {
            this.oProduto.Nome = this.txtNomeP.Text;
            this.oProduto.Descricao = this.txtDescricao.Text;
            if (txtPreco.Text.Contains("."))
            {
                txtPreco.Text = txtPreco.Text.Replace(".", ",");
            }
            this.oProduto.Preco = decimal.Parse(this.txtPreco.Text);
            this.oProduto.QntEstoque = int.Parse(this.txtQntEstoque.Text);
        }

       
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //var btprod = new AdmProduto();
            //btprod.produto = new Produto();
            //try
            //{
            //    if (btprod.ShowDialog() == DialogResult.OK)
            //    {
            //        db.Produto.Add(btprod.produto);
            //        db.SaveChanges();

            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            update();
            this.DialogResult = DialogResult.OK;
           
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtNomeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQntEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
