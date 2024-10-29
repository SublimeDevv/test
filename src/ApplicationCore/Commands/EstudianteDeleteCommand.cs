using ApplicationCore.Wrappers;
using MediatR;

namespace ApplicationCore.Commands;

public class EstudianteDeleteCommand : IRequest<Response<int>>
{
    public int Id { get; set; }
}
