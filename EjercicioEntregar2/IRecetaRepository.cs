using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface IRecetaRepository
    {
        void Create(Receta _Receta);
        Receta Lee(string _Nombre);
        void Delete(string _Nombre);
        void Update(string _Nombre, string _NuevoNombre);
        IList<Receta> Lista();
    }
}