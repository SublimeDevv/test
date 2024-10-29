using ApplicationCore.Commands;
using AutoMapper;

namespace ApplicationCore.Mappings;

public class Estudiantes: Profile
{
    public Estudiantes()
    {
        CreateMap<EstudianteCreateCommand, Domain.Entities.Estudiantes>().ForMember(x => x.Id, y => y.Ignore());
        // CreateMap<EstudianteCreateCommand, Estudiantes>().ForMember(x => x.Id, y => y.Ignore());
        CreateMap<EstudianteUpdateCommand, Domain.Entities.Estudiantes>()
            .ForMember(x => x.Id, y => y.Ignore());
    }
}