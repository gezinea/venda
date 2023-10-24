using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.Auxiliares
{
    public class AXfornecedores
    {
        public Guid IdFornecedores { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        //endereco
        public Guid idEndereco { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string CEP { get; set; }
        public int Quadra { get; set; }
    }
}
