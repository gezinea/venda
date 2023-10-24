using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.Auxiliares
{
    public class AXproduto
    {
        public Guid idProduto { get; set; }
        public int QntEstoque { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
    }
}
