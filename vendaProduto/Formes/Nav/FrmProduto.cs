using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Conexao;
using ErpSigmaVenda.Persistencia;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    public partial class FrmProduto : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Produto oProduto { get; set; }
        public AXproduto auxProduto { get; set; }
        public Usuario oUsuario { get; set; }


        public FrmProduto()
        {
            InitializeComponent();
        }    

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadProduto prod = new FrmCadProduto();
            prod.oProduto = new Produto();
            prod.oProduto.idProduto = Guid.NewGuid();
            if (prod.ShowDialog() == DialogResult.OK)
            {
                db = new VendaProdutoEntities();
                db.Produto.Add(prod.oProduto);
                db.SaveChanges();
                loading();
            }
        }

        private void loading()
        {
           // dgProduto.DataSource = db.Produto.ToList();
            dgProduto.DataSource = pProduto.find();

        }

        private void AdmProduto_Load(object sender, EventArgs e)
        {
            
            if (pUsuario.ousuario.tipoUser.Equals("Adm"))
           {
               btAdicionar.Visible = true;
               btEditar.Visible = true;
               btDeletar.Visible = true;
           }
           else
           {
               btAdicionar.Visible = false;
               btEditar.Visible = true;
               btDeletar.Visible = false;
           }
            loading();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            FrmCadProduto cad = new FrmCadProduto();
            cad.oProduto = new Produto();
            cad.oProduto = db.Produto.Find(auxProduto.idProduto);
            if(cad.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                loading();
            }
        }

        private void dgProduto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgProduto.Rows.Count > 0)
                {
                    auxProduto = (AXproduto)dgProduto.SelectedRows[0].DataBoundItem;
                }
            }
            catch (Exception)
            {

            }
        }
        private void IdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            try
            {
                if (MessageBox.Show("Tem certeza que deseja deletar essa linha?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Produto.Remove(db.Produto.Find(auxProduto.idProduto));
                    db.SaveChanges();
                    loading();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
