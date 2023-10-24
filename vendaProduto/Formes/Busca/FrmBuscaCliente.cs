using ErpSigmaVenda.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;

using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Persistencia;
using System.Windows.Forms;

namespace ErpSigmaVenda.Formes.Busca
{
    public partial class FrmBuscaCliente : Form
    {
        VendaProdutoEntities db = new VendaProdutoEntities();
        public Cliente cliente { get; set; }
        public Endereco oEndereco { get; set; }
        public AXcliente ocliente { get; set; }

        public FrmBuscaCliente()
        {
            InitializeComponent();
        }


        private void BuscaClie_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            dgBuscaCli.DataSource = pBusca.find();

        }
        private void btBusca_Click(object sender, EventArgs e)
        {
            loading();

        }

        private void btConfirma_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void dgBuscaCli_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgBuscaCli.Rows.Count > 0)
                {
                    ocliente = (AXcliente)dgBuscaCli.SelectedRows[0].DataBoundItem;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> lst = new List<Cliente>();
            dgBuscaCli.DataSource = lst;
            dgBuscaCli.DataSource = pBusca.find().Where(o => o.nome.Contains(txtBusca.Text)).ToList();
        }
    }
}
