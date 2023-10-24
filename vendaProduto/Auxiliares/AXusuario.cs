using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.Auxiliares
{
    public class AXusuario
    {
        public Guid idusuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNacimento { get; set; }
        public string tipoUser { get; set; }
        public string sexo { get; set; }
        public string nomeU { get; set; }
        public string CPF { get; set; }

        //endereco
        public Guid idEndereco { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string CEP { get; set; }
        public int Quadra { get; set; }
        


    }
}
