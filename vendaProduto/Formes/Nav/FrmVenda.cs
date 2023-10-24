using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Cadastros;
using ErpSigmaVenda.Conexao;
using ErpSigmaVenda.Persistencia;
using System;
using System.Windows.Forms;

namespace ErpSigmaVenda.Navegacao
{
    public partial class FrmVenda : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public AXclienteProd auxClienteProd { get; set; }
        public Cliente oCliente { get; set; }
        public Endereco oEndereco { get; set; }
        public Venda oVenda { get; set; }

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            auxClienteProd = new AXclienteProd();
           
                    loadind();
        }

        private void loadind()
        {
            dgVendas.DataSource = pProduto.find();
            //cadastro de venda
            if (auxClienteProd.DtVenda > DateTime.Parse("1920-01-01"))
            {
                this.txtDtVenda.Text = this.auxClienteProd.DtVenda.ToShortDateString();
            }
            this.txtQntVenda.Text = this.auxClienteProd.QntVenda.ToString();
            this.txtTotal.Text = this.auxClienteProd.PreecoVenda.ToString();


        }

        private void update()
        {
            this.auxClienteProd.DtVenda = DateTime.Parse(this.txtDtVenda.Text);
            this.auxClienteProd.QntVenda = int.Parse(this.txtQntVenda.Text);
            this.auxClienteProd.PreecoVenda = decimal.Parse(this.txtTotal.Text);

            this.auxClienteProd.idUsuario = pUsuario.ousuario.IdUsuario;
            this.auxClienteProd.IdCliente = Guid.Parse(txtIdCliente.Text);
            

            for (int i = 0; i < dgVendas.Rows.Count; ++i)
            {
                db = new VendaProdutoEntities();
                BuscaClie bc = new BuscaClie();
                ErpSigmaVenda.Conexao.Venda vd = new ErpSigmaVenda.Conexao.Venda();
                vd.IdVenda = Guid.NewGuid();
                vd.IdCliente = this.auxClienteProd.IdCliente;
                vd.IdUsuario = auxClienteProd.idUsuario;
                this.auxClienteProd.idProduto = Guid.Parse(dgVendas.Rows[i].Cells["idProdutoColumn"].Value.ToString());
                vd.QntVenda = int.Parse(dgVendas.Rows[i].Cells["QtdVendaColumn"].Value.ToString());
                vd.PreecoVenda = decimal.Parse(dgVendas.Rows[i].Cells["ValorTotaColumn"].Value.ToString());
                vd.idProduto = auxClienteProd.idProduto;
                vd.DtVenda = this.auxClienteProd.DtVenda;
                db.Venda.Add(vd);
                db.SaveChanges();

            }

            
            
        }
        private void btCadCliente_Click(object sender, EventArgs e)
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

        private void btBuscaCli_Click(object sender, EventArgs e)
        {
            BuscaClie bc = new BuscaClie();
            bc.ocliente = new AXcliente();
            bc.oEndereco = new Endereco();
            if (bc.ShowDialog() == DialogResult.OK)
            {
                txtNomecli.Text = bc.ocliente.nome;
                txtCPFc.Text = bc.ocliente.CPF;
                txtCEP.Text = bc.ocliente.CEP;
                txtNum.Text = Convert.ToString(bc.oEndereco.Quadra.ToString());
                txtIdCliente.Text = bc.ocliente.IdCliente.ToString();
                loadind();
            }

        }

        private void btCadVenda_Click(object sender, EventArgs e)
        {
            //    txtQntVenda.Text = auxClienteProd.QntVenda.ToString();
            //    dgVendas.UpdateCellValue(3, txtQntVenda.  );
            if (MessageBox.Show("Finalizar Venda?", "Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update(); 
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            
        }

        private void dgVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgVendas.Rows.Count > 0)
                {
                    auxClienteProd = (AXclienteProd)dgVendas.SelectedRows[0].DataBoundItem;
                }
            }
            catch (Exception)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgVendas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qtd = 0;
            decimal ttl = 0;

            for (int i = 0; i < dgVendas.Rows.Count; i++)
            {
                int Quantidade = 0;
                decimal Preco = 0;
                decimal total=0;
                if (dgVendas.Rows[i].Cells[QtdVendaColumn.Index].Value != null)
                {
                    int.TryParse(dgVendas.Rows[i].Cells[QtdVendaColumn.Index].Value.ToString(), out Quantidade);
                    if (Quantidade > 0)
                    {
                        decimal.TryParse(dgVendas.Rows[i].Cells[precocollunm.Index].Value.ToString(), out Preco);
                        dgVendas.Rows[i].Cells[ValorTotaColumn.Index].Value = (Quantidade * Preco);
                        decimal.TryParse(dgVendas.Rows[i].Cells[ValorTotaColumn.Index].Value.ToString(), out total);
                    }
                    
                }

                //if (int.TryParse(dgVendas.Rows[e.RowIndex].Cells["QtdVendaColumn"].Value.ToString(), out Quantidade) && decimal.TryParse(dgVendas.Rows[e.RowIndex].Cells["precocollunm"].Value.ToString(), out Preco))
                //{
                    
                //    txtTotal.Text += total.ToString();
                //    //dgVendas.Rows[e.RowIndex].Cells["ValorTotaColumn"].Value = total.ToString();
                //}

                qtd += Quantidade;
                ttl += total;
                txtQntVenda.Text = qtd.ToString();
                txtTotal.Text = ttl.ToString();
            }
          

            //decimal sum = 0;
            //for (int i = 0; i < dgVendas.Rows.Count; ++i)
            //{
            //    sum += Convert.ToInt32(dgVendas.Rows[i].Cells[4].Value);
            //}
            //txtQntVenda.Text = sum.ToString();


        }
        private void label3_Click_1(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var pd = new FrmProduto();
            pd.oProduto = new Produto();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                db.Produto.Add(pd.oProduto);
                db.SaveChanges();
            }
        }

        private void btAlterarProd_Click(object sender, EventArgs e)
        {
            FrmVenda ven = new FrmVenda();
            db.Venda.Find(auxClienteProd.idVenda);
            db.Produto.Find(auxClienteProd.idProduto);
            db.Cliente.Find(auxClienteProd.IdCliente);
            db.Usuario.Find(auxClienteProd.idUsuario);
            if (ven.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                db = new VendaProdutoEntities();
                Produto update_produto = db.Produto.Find(auxClienteProd.idProduto);

                //txtNomecli.Text = bc.ocliente.nome;
                //txtCPFc.Text = bc.ocliente.CPF;
                //txtCEP.Text = bc.ocliente.CEP;
                //txtNum.Text = int.Parse(bc.oEndereco.Quadra.ToString()).ToString();
                loadind();
                db.SaveChanges();
                loadind();
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            db = new VendaProdutoEntities();
            try
            {
                if (MessageBox.Show("Tem certeza que deseja deletar essa linha?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Venda.Remove(db.Venda.Find(auxClienteProd.idVenda));
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
