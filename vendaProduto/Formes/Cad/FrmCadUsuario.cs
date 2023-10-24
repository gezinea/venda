using ErpSigmaVenda.Conexao;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    public partial class FrmCadUsuario : Form
    {
        public Usuario oUsuario { get; set; } 
        public Endereco endereco { get; set; }

        //combo box
        public string Feminino { get; set; }
        public string Masculino { get; set; }
        public string Administrador { get; set; }
        public string Vendedor { get; set; }
        VendaProdutoEntities db = new VendaProdutoEntities();


        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void cadastroUser_Load(object sender, EventArgs e)
        {
            loading();
            cbSexo.SelectedIndex = 0;
            cbTipoUsuario.SelectedIndex = 0;

        }
        private void update()
        {
            this.oUsuario.Nome = this.txtnomeU.Text;
            this.oUsuario.Email = this.txtEmail.Text;
            this.oUsuario.CPF = this.txtCPFU.Text;
            this.oUsuario.Telefone = this.txtTelefone.Text;
            this.oUsuario.senhaUser = this.cadSenhaU.Text;
            this.oUsuario.sexo = this.cbSexo.SelectedItem.ToString().Equals("Feminino")?"f":"M";
            this.oUsuario.tipoUser = this.cbTipoUsuario.SelectedItem.ToString().Equals("Administrador") ? "Adm" : "Ven";


            this.oUsuario.DtNacimento = DateTime.Parse(this.dtNasciUser.Text);

            //endereco
            this.endereco.CEP = this.txtCep.Text;
            this.endereco.Bairro = this.txtBairro.Text;
            this.endereco.Rua = this.txtRua.Text;
            this.endereco.Quadra = int.Parse(this.txtQuadra.Text);
        }
        private void loading()
        {
            this.txtnomeU.Text = this.oUsuario.Nome;
            this.txtEmail.Text = this.oUsuario.Email;
            this.txtCPFU.Text = this.oUsuario.CPF;
            this.txtTelefone.Text = this.oUsuario.Telefone;
            this.cadSenhaU.Text = this.oUsuario.senhaUser;
            this.cbSexo.Text = this.oUsuario.sexo;
            this.cbTipoUsuario.Text = this.oUsuario.tipoUser;
            if(oUsuario.DtNacimento > DateTime.Parse("1950-01-01"))
            {
                this.dtNasciUser.Text = this.oUsuario.DtNacimento.ToShortDateString();

            }


            //endereco
            this.txtCep.Text = this.endereco.CEP;
            this.txtBairro.Text = this.endereco.Bairro;
            this.txtRua.Text = this.endereco.Rua;
            this.txtQuadra.Text = this.endereco.Quadra.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cdSenha_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
         

        private void txtnomeU_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTelefoneU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //var btCad = new visualUser();
            //btCad.usario = new Usuario();
            //if (btCad.ShowDialog() == DialogResult.OK)
            //{
            //    db.Usuario.Add(btCad.usario);
            //    db.SaveChanges();              
            //}

            if (String.IsNullOrEmpty(cfmSenha.Text) && String.IsNullOrEmpty(txtnomeU.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Alerta");
            }
            else
            {
                update();
                this.DialogResult = DialogResult.OK;
            }

          
        }

        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cfmSenha_Leave(object sender, EventArgs e)
        {
            if(cadSenhaU.Text != cfmSenha.Text)
            {
                MessageBox.Show("Senhas diferentes", "Incompatibilidade");
                cfmSenha.Text = "";
            }
            //else
            //{
            //    update();
            //    this.DialogResult = DialogResult.OK;
            //}
        }

        private void txtnomeU_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnomeU.Text))
            {
                MessageBox.Show("Campo obrigatório");
            }
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
