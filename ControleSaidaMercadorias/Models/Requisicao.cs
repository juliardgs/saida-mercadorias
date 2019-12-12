using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSaidaMercadorias.Models
{
    class Requisicao
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime Data { get; set; }
        public double PrecoCustoTotal { get; set; } 
        public List<Produto> ItensReq { get; set; }
    }
}
