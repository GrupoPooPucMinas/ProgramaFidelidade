using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFidelidade
{
    class Manga : ICategoria
    {
        public double CalcBonus(double BonusVoo, int tipo)
        {
            if (tipo == 3)
            {
                return BonusVoo;
            }
            else
            {
                return BonusVoo * 1.5;
            }
        }
    }
}
