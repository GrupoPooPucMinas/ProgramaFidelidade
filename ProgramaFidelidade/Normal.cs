using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFidelidade
{
    class Normal : Voo
    {
        public Normal(string nome, string origem, string destino, DateTime dt) : base(nome, origem, destino, dt)
        {
            this.Bonus = 1000;
        }

        public Normal(string nome, string origem, string destino) : base(nome, origem, destino)
        {
            this.Bonus = 1000;
        }
    }
}
