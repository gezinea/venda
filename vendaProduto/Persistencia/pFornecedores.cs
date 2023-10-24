
using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;

using ErpSigmaVenda.Auxiliares;

namespace ErpSigmaVenda.Persistencia
{
    class pFornecedores
    {
        public static IEnumerable<AXfornecedores> find()
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            string query = "SELECT Fornecedores.IdFornecedores, Fornecedores.Nome , Fornecedores.Cnpj, Endereco.idEndereco, Endereco.Bairro, Endereco.CEP, Endereco.Quadra, Endereco.Rua FROM Fornecedores inner join Endereco on Fornecedores.idEndereco = Endereco.idEndereco;";


            return db.Database.SqlQuery<AXfornecedores>(query).ToList();
        }
    }
}
