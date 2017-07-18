using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository Recetario;

        public RecetaService(IRecetaRepository _Recetario)
        {
            this.Recetario = _Recetario;
        }
        public void Create(Receta _Receta)
        {
            Recetario.Create(_Receta);
        }

        public Receta Lee(String _Nombre)
        {
            return Recetario.Lee(_Nombre);
        }

        public IList<Receta> Lista()
        {
            return Recetario.Lista();
        }

        public void Update(String _Nombre, String _NuevoNombre)
        {
            Recetario.Update(_Nombre, _NuevoNombre);
        }

        public void Delete(String _Nombre)
        {
            Recetario.Delete(_Nombre);
        }
    }
}
