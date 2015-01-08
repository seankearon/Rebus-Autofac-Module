using System;
using Autofac;
using Autofac.Core.Registration;
using Xbehave;
using Xunit;

namespace AutofacRegistration
{
    public class Specs
    {
        [Scenario]
        public void Registration(IContainer c, Exception e)
        {
            "When using the Rebus Autofac module".f(() =>
            {
                var b = new ContainerBuilder();
                b.RegisterAssemblyModules(GetType().Assembly);
                c = b.Build();
            });

            "Handlers can be resolved by interface".f(() => Assert.NotNull(c.Resolve<IHandleMessages<WebEvent1>>()));

            "Handlers cannot be resolved by type".f(() =>
            {
                e = Record.Exception(() => c.Resolve<Handler>());
                Assert.IsType<ComponentNotRegisteredException>(e);
            });

            "Other types are not registered".f(() =>
            {
                e = Record.Exception(() => c.Resolve<WebEvent1>());
                Assert.IsType<ComponentNotRegisteredException>(e);
            });
        }

    }
}