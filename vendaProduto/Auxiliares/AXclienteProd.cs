using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.Auxiliares
{
    public class AXclienteProd
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public Guid IdCliente { get; set; }
        public string CEP { get; set; }
        public string Quadra { get; set; }

        //produto
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
        public Guid idProduto { get; set; }

        //venda
        public Guid idVenda { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal PreecoVenda { get; set; }
        public int QntVenda { get; set; }

        //usuario
        public Guid idUsuario { get; set; }
        public string NomeU { get; set; }
        public string CPFU { get; set; }
    }
}
