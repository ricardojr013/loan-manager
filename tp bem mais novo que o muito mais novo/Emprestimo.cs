using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    public class Emprestimo
    {
        public float valor { get; set; }
        public DateTime data { get; set; }
        public Usuario usuarioCredor;
        public Usuario usuarioDevedor;
    }
}
