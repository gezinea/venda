

using ErpSigmaVenda.Conexao;
using System.Collections.Generic;
using System.Linq;
using ErpSigmaVenda.Auxiliares;

namespace ErpSigmaVenda.Persistencia
{
    public static class pUsuario
    {
        public static Usuario ousuario { get; set; }

        public static Usuario loginUsuario(string nome, string senha)
        {
            VendaProdutoEntities db = new VendaProdutoEntities();
            ousuario = db.Database.SqlQuery<Usuario>("SELECT * FROM Usuario WHERE Nome = '" + nome + "'  AND senhaUser = '" + senha + "'").FirstOrDefault();
            return ousuario;
        }
        public static IEnumerable<AXusuario> find() {
            VendaProdutoEntities db = new VendaProdutoEntities();
            string query = "SELECT Usuario.IdUsuario, Usuario.Nome as nomeU, Usuario.Email, Usuario.Telefone, Usuario.DtNacimento, Usuario.tipoUser, Usuario.sexo, Endereco.Rua as rua, Endereco.Bairro as bairro, Endereco.CEP, Endereco.Quadra, Endereco.idEndereco FROM Usuario inner join Endereco on Usuario.idEndereco = Endereco.idEndereco; ";


            return db.Database.SqlQuery<AXusuario>(query).ToList();
    }
    }
}
