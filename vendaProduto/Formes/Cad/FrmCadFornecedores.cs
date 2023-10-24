using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda.Navegacao
{
    public partial class FrmCadFornecedores : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Fornecedores oFornecedor { get; set; }
        public Endereco endereco { get; set; }

        public FrmCadFornecedores()
        {
            InitializeComponent();
        }

        private void cadFornecedores_Load(object sender, EventArgs e)
        {
            loading();
        }
        private void loading()
        {
            this.txtNome.Text = this.oFornecedor.Nome;
            this.txtCNPJ.Text = this.oFornecedor.Cnpj;
            this.txtBairro.Text = this.endereco.Bairro;
            this.txtQuadra.Text = this.endereco.Quadra.ToString();
            this.txtCEP.Text = this.endereco.CEP;
            this.txtRua.Text = this.endereco.Rua;
        }

        private void update()
        {
            this.oFornecedor.Nome = this.txtNome.Text;
            this.oFornecedor.Cnpj = this.txtCNPJ.Text;
            this.endereco.Bairro = this.txtBairro.Text;
            this.endereco.CEP = this.txtCEP.Text;
            this.endereco.Quadra = int.Parse(this.txtQuadra.Text);
            this.endereco.Rua = this.txtRua.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             update();
             this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
