using System;
using Autofac;
using Rebus;

namespace AutofacRegistration
{
    /// <summary>
    /// An Autofac <see cref="Module"/> that scans the current assembly and registers Rebus handlers by interfaces.
    /// </summary>
    public class RebusHandlerModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .Where(IsRebusHandler)
                .AsImplementedInterfaces();
        }

        private bool IsRebusHandler(Type t)
        {
            return typeof(IHandleMessages).IsAssignableFrom(t);
        }
    }
}