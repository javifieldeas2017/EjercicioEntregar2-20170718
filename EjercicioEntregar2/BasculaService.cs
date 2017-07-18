using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class BasculaService : IBasculaService
    {
        public float Pesar(Alimento mAlimento)
        {
            return mAlimento.Peso;
        }
    }
}
