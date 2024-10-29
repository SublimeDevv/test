using ApplicationCore.Commands;
using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using AutoMapper;
using Infraestructure.Persistence;
using MediatR;

namespace Infraestructure.EventHandlers.Estudiantes;

public class DeleteEstudianteHandler : IRequestHandler<EstudianteDeleteCommand, Response<int>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IEstudiantesService _service;

    public DeleteEstudianteHandler(ApplicationDbContext context, IMapper mapper, IEstudiantesService service)
    {
        _context = context;
        _mapper = mapper;
        _service = service;
    }

    public async Task<Response<int>> Handle(EstudianteDeleteCommand command, CancellationToken cancellationToken)
    {
        var estudiante = await _context.Estudiantes.FindAsync(command.Id);

        if (estudiante == null)
        {
            return new Response<int>($"Estudiante con Id {command.Id} no encontrado.");
        }

        _context.Estudiantes.Remove(estudiante);
        await _context.SaveChangesAsync(cancellationToken);

        return new Response<int>(command.Id, "Estudiante eliminado exitosamente.");
    }
}