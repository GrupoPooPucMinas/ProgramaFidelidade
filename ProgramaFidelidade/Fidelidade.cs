using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFidelidade
{
    class Fidelidade : Voo
    {
        public Fidelidade(string nome, string origem, string destino, DateTime dt) : base(nome, origem, destino, dt)
        {
            this.Bonus = -10000;
        }

        public Fidelidade(string nome, string origem, string destino) : base(nome, origem, destino)
        {
            this.Bonus = -10000;
        } 

    }
}
