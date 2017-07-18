using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        public static IList<Receta> ListaRecetas = new List<Receta>();

        public void Create(Receta _Receta)
        {
            ListaRecetas.Add(_Receta);
        }

        public Receta Lee(String _Nombre)
        {
            return new Receta(new Alimento(), new Alimento());
        }

        public IList<Receta> Lista()
        {
            return ListaRecetas;
        }

        public void Update(String _Nombre,String _NuevoNombre)
        {
            
        }

        public void Delete(String _Nombre)
        {

        }
    }
}
