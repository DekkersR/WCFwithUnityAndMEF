using System;
using System.ServiceModel;
using Unity;

namespace DEMO.Common.Unity
{
    public class UnityInstanceContextExtension : IExtension<InstanceContext>
    {
        private IUnityContainer _childContainer;

        public IUnityContainer GetChildContainer(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            return _childContainer ?? (_childContainer = container.CreateChildContainer());
        }

        public void DisposeOfChildContainer()
        {
            _childContainer?.Dispose();
        }

        public void Attach(InstanceContext owner)
        {
        }

        public void Detach(InstanceContext owner)
        {
        }
    }
}
