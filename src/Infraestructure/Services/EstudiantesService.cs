using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Services
{
    public class EstudiantesService: IEstudiantesService
    {
        private readonly ApplicationDbContext _dbContext;

        public EstudiantesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Response<object>> GetEstudiantes()
        {
            object list = new object();
            list = await _dbContext.Estudiantes.ToListAsync();
            return new Response<object>(list);
        }
    }
}

