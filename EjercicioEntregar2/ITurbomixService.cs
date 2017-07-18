namespace EjercicioEntregar2
{
    public interface ITurbomixService
    {
        Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2);
        Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2, Receta Receta);
    }
}