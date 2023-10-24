
using ErpSigmaVenda.Auxiliares;
using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;

namespace ErpSigmaVenda.Persistencia
{
    public class pCliente
    {
        public static Cliente ocliente { get; set; }

        public static IEnumerable<AXcliente> find()
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            string query = "SELECT Cliente.IdCliente, Cliente.nome, Cliente.CPF, Cliente.Email, Cliente.DtNascimento, Cliente.telefone, Cliente.sexo, Endereco.idEndereco, Endereco.Bairro, Endereco.CEP, Endereco.Rua, Endereco.Quadra FROM Cliente INNER JOIN Endereco on cliente.idEndereco = Endereco.idEndereco;";



            return db.Database.SqlQuery<AXcliente>(query).ToList();
        }


    }
}
