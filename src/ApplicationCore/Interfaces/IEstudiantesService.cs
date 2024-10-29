using ApplicationCore.Wrappers;

namespace ApplicationCore.Interfaces
{
    public interface IEstudiantesService
    {
        Task<Response<object>> GetEstudiantes();
    }
}