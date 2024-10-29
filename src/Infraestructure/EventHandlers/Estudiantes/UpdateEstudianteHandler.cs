namespace Infraestructure.EventHandlers.Estudiantes;

using ApplicationCore.Commands;
using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using AutoMapper;
using Infraestructure.Persistence;
using MediatR;

public class UpdateEstudianteHandler : IRequestHandler<EstudianteUpdateCommand, Response<int>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IEstudiantesService _service;

    public UpdateEstudianteHandler(ApplicationDbContext context, IMapper mapper, IEstudiantesService service)
    {
        _context = context;
        _mapper = mapper;
        _service = service;
    }

    public async Task<Response<int>> Handle(EstudianteUpdateCommand command, CancellationToken cancellationToken)
    {
        var estudiante = await _context.Estudiantes.FindAsync(command.Id);

        if (estudiante == null)
        {
            return new Response<int>($"Estudiante con Id {command.Id} no encontrado.");
        }

        estudiante.Nombre = command.Nombre;
        estudiante.Edad = command.Edad;
        estudiante.Correo = command.Correo;

        await _context.SaveChangesAsync(cancellationToken);

        return new Response<int>(estudiante.Id, "Estudiante actualizado exitosamente.");
    }
}
