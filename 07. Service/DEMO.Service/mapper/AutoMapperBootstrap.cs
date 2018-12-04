using AutoMapper;

namespace DEMO.Service.mapper
{
    public class AutoMapperBootstrap : Profile
    {
        public AutoMapperBootstrap()
        {
            CreateMap<Entities.Todo, TodoDto>();
        }
    }
}