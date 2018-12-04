using DEMO.Business.Interfaces;
using DEMO.Common.MEF.Interface;
using System.Composition;
using System.Diagnostics.CodeAnalysis;

namespace DEMO.Business
{
    [ExcludeFromCodeCoverage] //assumed IModuleRegistrar is tested
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterType<ISomeService, SomeService>();
        }
    }
}
