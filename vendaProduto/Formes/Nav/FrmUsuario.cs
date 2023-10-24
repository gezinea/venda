

using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Conexao;
using ErpSigmaVenda.Persistencia;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda.Navegacao
{
    public partial class FrmUsuario : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Usuario oUsuario { get; set; }
        public AXusuario auxUsuario { get; set; }

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadUsuario user = new FrmCadUsuario();
            user.oUsuario = new Usuario();
            user.oUsuario.IdUsuario = Guid.NewGuid();
            user.endereco = new Endereco();
            user.endereco.idEndereco = Guid.NewGuid();
            if(user.ShowDialog() == DialogResult.OK)
            {
                db = new VendaProdutoEntities();
                db.Endereco.Add(user.endereco);
                db.SaveChanges();
                db = new VendaProdutoEntities();
                user.oUsuario.idEndereco = user.endereco.idEndereco;
                db.Usuario.Add(user.oUsuario);
                db.SaveChanges();
                loadind();
            }
        }
        
        private void loadind()
        {
            dgUsuario.DataSource = pUsuario.find();

        }
        private void visualUser_Load(object sender, EventArgs e)
        {
            loadind();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            FrmCadUsuario cad = new FrmCadUsuario();
            cad.oUsuario = new Usuario();
            cad.endereco = new Endereco();
            cad.oUsuario = db.Usuario.Find(auxUsuario.idusuario);
            cad.endereco = db.Endereco.Find(cad.oUsuario.idEndereco);
            if(cad.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                db = new VendaProdutoEntities();
                Endereco update_endereco = db.Endereco.Find(cad.oUsuario.idEndereco);
                update_endereco = cad.endereco;            
                db.SaveChanges();

                loadind();
            }
        }

        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuario.Rows.Count > 0)
                {
                    auxUsuario = (AXusuario)dgUsuario.SelectedRows[0].DataBoundItem;
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
                    db.Usuario.Remove(db.Usuario.Find(auxUsuario.idusuario));
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
