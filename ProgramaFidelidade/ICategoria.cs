using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFidelidade
{
    interface ICategoria
    {
       double CalcBonus(double BonusVoo, int tipo);
    }
}
