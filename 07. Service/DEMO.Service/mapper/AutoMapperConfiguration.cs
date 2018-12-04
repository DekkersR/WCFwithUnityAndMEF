using AutoMapper;

namespace DEMO.Service.mapper
{
    public class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperBootstrap>();
            });
            return config;
        }
    }
}