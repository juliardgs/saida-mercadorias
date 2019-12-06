using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSaidaMercadorias.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public List<Produto> ItemProduto { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
    }
}
