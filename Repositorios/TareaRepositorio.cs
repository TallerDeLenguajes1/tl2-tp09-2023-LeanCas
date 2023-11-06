


public class TareaRepositorio : ITareaRepositorio
{
    public void Asignar(int idUsuario, int idTarea)
    {
        throw new NotImplementedException();
    }

    public Tarea Create(int idTablero)
    {
        throw new NotImplementedException();
    }

    public void Delete(int idTarea)
    {
        throw new NotImplementedException();
    }

    public List<Tarea> GetAll()
    {
        try
        {
            return new List<Tarea>();
        }
        catch
        {
            throw;
        }
    }

    public Tarea GetTarea(int id)
    {
        try
        {
            return new Tarea();
        }
        catch
        {
            throw;
        }
    }

    public List<Tarea> GetTareaTablero(int idTablero)
    {
        try
        {
            return new List<Tarea>();
        }
        catch
        {
            throw;
        }
    }

    public void Set(int id, Tarea tarea)
    {
        try
        {

        }
        catch
        {
            throw;
        }
    }
}