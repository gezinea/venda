
using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;
using ErpSigmaVenda.Auxiliares;

namespace ErpSigmaVenda.Persistencia
{
    public static class pProduto
    {
        public static Produto oproduto { get; set; }
        public static IEnumerable<AXproduto> find()
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            string query = "SELECT Produto.idProduto, Produto.QntEstoque, Produto.Nome, Produto.Preco, Produto.Descricao from Produto;";


            return db.Database.SqlQuery<AXproduto>(query).ToList();
        }
    }
}
