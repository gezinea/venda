

using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;
using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Navegacao;
using ErpSigmaVenda.Formes.Busca;

namespace ErpSigmaVenda.Persistencia
{
    public class pBusca
    {
        public static FrmBuscaCliente obusca { get; set; }

        public static IEnumerable<AXcliente> find()
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            var query = "SELECT cliente.IdCliente, Cliente.nome, Cliente.CPF, cliente.DtNascimento, Cliente.Email, Cliente.sexo, Cliente.telefone, Endereco.idEndereco, Endereco.Bairro, Endereco.CEP, Endereco.Quadra, Endereco.Rua " +
                         "FROM Cliente INNER JOIN Endereco on cliente.idEndereco = Endereco.idEndereco";
            return db.Database.SqlQuery<AXcliente>(query).ToList();
            //return obusca;
        }
    }
}
