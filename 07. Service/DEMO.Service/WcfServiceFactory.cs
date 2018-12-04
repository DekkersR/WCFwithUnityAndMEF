using AutoMapper;
using DEMO.Business;
using DEMO.Business.Interfaces;
using DEMO.Common.MEF;
using DEMO.Common.Unity;
using DEMO.Service.mapper;
using System.Diagnostics.CodeAnalysis;
using Unity;

namespace DEMO.Service
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        [ExcludeFromCodeCoverage] // assumption is used methods are already tested
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container
                .RegisterType<ITodoService, TodoService>()
                //.RegisterType<ISomeService, SomeService>()
                .RegisterInstance<IMapper>(new AutoMapperConfiguration().Configure().CreateMapper())
            ;

            ModuleLoader.LoadContainer(container, ".\\bin", "DEMO.*.dll");
        }
    }
}