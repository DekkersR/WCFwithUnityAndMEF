using DEMO.Common.MEF.Interface;
using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Unity;

namespace DEMO.Common.MEF
{
    public class ModuleLoader
    {
        public static void LoadContainer(IUnityContainer container, string path, string pattern)
        {
            //DirectoryCatalog
            var directory = AppDomain.CurrentDomain.BaseDirectory + "\\bin";
            var files = Directory.EnumerateFiles(directory, pattern, SearchOption.AllDirectories);
            var listOfAssamlies = getAssemblies(files.ToList());

            var configuration = new ContainerConfiguration().WithAssemblies(listOfAssamlies);
            var configContainer = configuration.CreateContainer();

            try
            {
                var modules = configContainer.GetExports<IModule>().Where(m => m != null);
                var registrar = new ModuleRegistrar(container);

                foreach (IModule module in modules)
                {
                    module.Initialize(registrar);
                }
            }
            catch (ReflectionTypeLoadException typeLoadException)
            {
                var builder = new StringBuilder();
                foreach (Exception loaderException in typeLoadException.LoaderExceptions)
                {
                    builder.AppendFormat("{0}\n", loaderException.Message);
                }

                throw new TypeLoadException(builder.ToString(), typeLoadException);
            }
            catch (Exception)
            {

            }
        }

        private static IEnumerable<Assembly> getAssemblies(List<string> pathList)
        {
            foreach (var file in pathList)
            {
                yield return Assembly.LoadFile(file);
            }
        }
    }
}
