using AutoMapper;
using DEMO.Common.MEF;
using DEMO.Common.Unity;
using DEMO.Service.mapper;
using System.Diagnostics.CodeAnalysis;
using Unity;
using Unity.Lifetime;

namespace DEMO.Service
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        [ExcludeFromCodeCoverage] // assumption is used methods are already tested
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<ITodoService, TodoService>(new ContainerControlledLifetimeManager())
                .RegisterInstance<IMapper>(new AutoMapperConfiguration().Configure().CreateMapper())
            ;

            ModuleLoader.LoadContainer(container, "DEMO.*.dll");
        }
    }
}