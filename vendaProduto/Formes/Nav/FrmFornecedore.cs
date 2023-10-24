

using ErpSigmaVenda.Conexao;
using ErpSigmaVenda.Persistencia;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ErpSigmaVenda.Auxiliares;

namespace ErpSigmaVenda.Navegacao
{
    public partial class FrmFornecedore : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Fornecedores oFornecedor { get; set; }
        public AXfornecedores auxFornecedor { get; set; }
      

        public FrmFornecedore()
        {
            InitializeComponent();
        }

        private void loading()
        {
            dgFornecedores.DataSource = db.Fornecedores.ToList();
            dgFornecedores.DataSource = pFornecedores.find();

        }
        private void Fornecedores_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadFornecedores cad = new FrmCadFornecedores();
            cad.oFornecedor = new Fornecedores();
            cad.oFornecedor.IdFornecedores = Guid.NewGuid();
            cad.endereco = new Endereco();
            cad.endereco.idEndereco = Guid.NewGuid();
            if(cad.ShowDialog() == DialogResult.OK)
            {
                db = new VendaProdutoEntities();
               
                db.Endereco.Add(cad.endereco);
                db.SaveChanges();
                db = new VendaProdutoEntities();
                cad.oFornecedor.idEndereco = cad.endereco.idEndereco;
                db.Fornecedores.Add(cad.oFornecedor);
                string cnpj = Regex.Replace(cad.oFornecedor.Cnpj, @"[^0-9a-zA-Z]+", "");
                             
                    cad.oFornecedor.Cnpj = cnpj;
                
                db.SaveChanges();
                loading();
            }

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            FrmCadFornecedores cad = new FrmCadFornecedores();
            cad.oFornecedor = new Fornecedores();
            cad.endereco = new Endereco();
            cad.oFornecedor = db.Fornecedores.Find(auxFornecedor.IdFornecedores);
            cad.endereco = db.Endereco.Find(cad.oFornecedor.idEndereco);
            if (cad.ShowDialog() == DialogResult.OK)
            {
                string cnpj = Regex.Replace(cad.oFornecedor.Cnpj, @"[^0-9a-zA-Z]+", "");
                
                cad.oFornecedor.Cnpj = cnpj;
                db.SaveChanges();
                db = new VendaProdutoEntities();
                Endereco update_endereco = db.Endereco.Find(cad.oFornecedor.idEndereco);
                update_endereco = cad.endereco;
                db.SaveChanges();

                loading();
            }
        }

        private void dgFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgFornecedores.SelectedRows.Count > 0) { 
                
                    auxFornecedor = (AXfornecedores)dgFornecedores.SelectedRows[0].DataBoundItem;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            try
            {
                 if (MessageBox.Show("Tem certeza que deseja deletar essa linha?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
                     db.Fornecedores.Remove(db.Fornecedores.Find(auxFornecedor.IdFornecedores));
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
