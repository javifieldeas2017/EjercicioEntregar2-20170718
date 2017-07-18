using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Receta
    {
        public Alimento Alimento1;
        public Alimento Alimento2;
        
        public Receta()
        {

        }
        public Receta(Alimento _Alimento1, Alimento _Alimento2)
        {
            this.Alimento1 = _Alimento1;
            this.Alimento2 = _Alimento2;
            
        }
    }
    

}
