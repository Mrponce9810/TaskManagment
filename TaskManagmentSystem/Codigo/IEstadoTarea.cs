namespace TaskManagmentSystem
{
    public interface IEstadoTarea
    {
        void Avanzar(TareaConcreta tarea);
        void Retroceder(TareaConcreta tarea);
        string ObtenerEstado();
    }
}
