using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.Auxiliares
{
    public class AXcliente
    {
        public Guid IdCliente { get; set; }
        public string Email { get; set; }
        public string telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string sexo { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }

        //endereco
        public Guid idEndereco { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int Quadra { get; set; }
    }
}
