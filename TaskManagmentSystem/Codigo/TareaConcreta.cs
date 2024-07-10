using System;
using System.Collections.Generic;

namespace TaskManagmentSystem
{
    public class TareaConcreta : ITarea
    {
        public string Nombre { get; set; }
        private List<ITarea> subtareas;
        public IEstadoTarea EstadoActual { get; set; }

        public TareaConcreta(string nombre)
        {
            Nombre = nombre;
            subtareas = new List<ITarea>();
            EstadoActual = new Pendiente(); // Estado inicial
        }

        public void AddSubtarea(ITarea tarea)
        {
            subtareas.Add(tarea);
        }

        public void RemoveSubtarea(ITarea tarea)
        {
            subtareas.Remove(tarea);
        }

        public List<ITarea> GetSubtareas()
        {
            return subtareas;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"{Nombre} - Estado: {EstadoActual.ObtenerEstado()}");
            foreach (var subtarea in subtareas)
            {
                subtarea.MostrarDetalles();
            }
        }

        public void AvanzarEstado()
        {
            EstadoActual.Avanzar(this);
        }

        public void RetrocederEstado()
        {
            EstadoActual.Retroceder(this);
        }
    }
}
