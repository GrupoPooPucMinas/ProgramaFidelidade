using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFidelidade
{
    class Promocional : Voo
    {
        public Promocional(string nome, string origem, string destino, DateTime dt) : base(nome, origem, destino, dt)
        {
            this.Bonus = 500;
        }

        public Promocional(string nome, string origem, string destino) : base(nome, origem, destino)
        {
            this.Bonus = 500;
        }
    }
}
