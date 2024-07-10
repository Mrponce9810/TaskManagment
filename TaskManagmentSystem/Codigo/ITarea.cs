using System.Collections.Generic;

namespace TaskManagmentSystem
{
    public interface ITarea
    {
        string Nombre { get; set; }
        void AddSubtarea(ITarea tarea);
        void RemoveSubtarea(ITarea tarea);
        List<ITarea> GetSubtareas();
        void MostrarDetalles();
    }
}
