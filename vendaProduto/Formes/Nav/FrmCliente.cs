using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;
using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Formes.Cad;
using ErpSigmaVenda.Persistencia;

namespace ErpSigmaVenda.Formes.Nav
{
    public partial class FrmCliente : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();

        public Cliente oCliente { get; set; }
        public AXcliente auxCliente { get; set; }

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            loadind();
        }

        private void loadind()
        {
            dgCliente.DataSource = pCliente.find();

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadCliente cad = new FrmCadCliente();
            cad.oCliente = new Cliente();
            cad.oCliente.IdCliente = Guid.NewGuid();
            cad.oEndereco = new Endereco();
            cad.oEndereco.idEndereco = Guid.NewGuid();
            if (cad.ShowDialog() == DialogResult.OK)
            {
                db = new VendaProdutoEntities();
                db.Endereco.Add(cad.oEndereco);
                db.SaveChanges();
                db = new VendaProdutoEntities();
                cad.oCliente.idEndereco = cad.oEndereco.idEndereco;
                db.Cliente.Add(cad.oCliente);
                db.SaveChanges();
                loadind();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            FrmCadCliente cad = new FrmCadCliente();
            cad.oCliente = new Cliente();
            cad.oEndereco = new Endereco();
            cad.oCliente = db.Cliente.Find(auxCliente.IdCliente);
            cad.oEndereco = db.Endereco.Find(cad.oCliente.idEndereco);
            if (cad.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                db = new VendaProdutoEntities();
                Endereco update_endereco = db.Endereco.Find(cad.oCliente.idEndereco);
                update_endereco = cad.oEndereco;
                db.SaveChanges();

                loadind();
            }
        }

        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgCliente.Rows.Count > 0)
                {
                    auxCliente = (AXcliente)dgCliente.SelectedRows[0].DataBoundItem;
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
                    db.Cliente.Remove(db.Cliente.Find(auxCliente.IdCliente));
                    db.SaveChanges();
                    loadind();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
