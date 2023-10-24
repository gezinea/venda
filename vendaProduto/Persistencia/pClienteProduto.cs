

using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;
using ErpSigmaVenda.Auxiliares;

namespace ErpSigmaVenda.Persistencia

{
    public class pCliProd
    {
        public static Venda ovenda { get; set; }

        public static IEnumerable<AXclienteProd> find()
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            string query = "SELECT Cliente.nome, Cliente.CPF, Cliente.IdCliente, Venda.DtVenda, Venda.PreecoVenda, Venda.QntVenda, Usuario.Nome, Produto.Nome, Produto.Preco, Produto.idProduto, Venda.IdVenda, Produto.idProduto, Usuario.IdUsuario from Venda inner JOIN Cliente on Cliente.IdCliente = Venda.IdCliente INNER JOIN Produto ON Produto.idProduto = Venda.idProduto INNER JOIN Usuario ON Usuario.IdUsuario = Venda.IdUsuario;";
             return db.Database.SqlQuery<AXclienteProd>(query).ToList();
        }
    }
}
