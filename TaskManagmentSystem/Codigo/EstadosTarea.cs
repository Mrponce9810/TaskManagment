using System;

namespace TaskManagmentSystem
{
    public class Pendiente : IEstadoTarea
    {
        public void Avanzar(TareaConcreta tarea)
        {
            tarea.EstadoActual = new EnProgreso();
        }

        public void Retroceder(TareaConcreta tarea)
        {
            Console.WriteLine("La tarea ya está en estado pendiente.");
        }

        public string ObtenerEstado()
        {
            return "Pendiente";
        }
    }

    public class EnProgreso : IEstadoTarea
    {
        public void Avanzar(TareaConcreta tarea)
        {
            tarea.EstadoActual = new Completada();
        }

        public void Retroceder(TareaConcreta tarea)
        {
            tarea.EstadoActual = new Pendiente();
        }

        public string ObtenerEstado()
        {
            return "En Progreso";
        }
    }

    public class Completada : IEstadoTarea
    {
        public void Avanzar(TareaConcreta tarea)
        {
            Console.WriteLine("La tarea ya está completada.");
        }

        public void Retroceder(TareaConcreta tarea)
        {
            tarea.EstadoActual = new EnProgreso();
        }

        public string ObtenerEstado()
        {
            return "Completada";
        }
    }
}
