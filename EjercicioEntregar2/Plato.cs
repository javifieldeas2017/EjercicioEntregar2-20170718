using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Plato
    {
        private Alimento mAlimento1;
        private Alimento mAlimento2;
        //public String NombrePlato;
        public Plato(Alimento mAlimento1, Alimento mAlimento2)
        {
            this.mAlimento1 = mAlimento1;
            this.mAlimento2 = mAlimento2;
            //NombrePlato = "" + mAlimento1 + mAlimento2;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            if (this.mAlimento1 == null && ((Plato) obj).mAlimento1 != null)
            {
                return false;
            }
            if (this.mAlimento1 != null && !this.mAlimento1.Equals(((Plato)obj).mAlimento1)) {
                return false;
            }

            if (this.mAlimento2 == null && ((Plato)obj).mAlimento2 != null)
            {
                return false;
            }
            if (this.mAlimento2 != null && !this.mAlimento2.Equals(((Plato)obj).mAlimento2))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return mAlimento1 + " al " + mAlimento2;
        }
    }
}
