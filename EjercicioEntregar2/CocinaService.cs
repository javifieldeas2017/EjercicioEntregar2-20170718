using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class CocinaService : ICocinaService
    {
        public void Calentar(Alimento mAlimento1, Alimento mAlimento2) {
            mAlimento1.Calentado = true;
            mAlimento2.Calentado = true;
        }
    }
}
