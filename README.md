# Rebus Autofac Module
An [Autofac](https://github.com/autofac/Autofac) Module that registers [Rebus](https://github.com/rebus-org/Rebus) handlers by scanning the assembly.

# Usage
Add the ['RebusHandlerModule'](https://github.com/seankearon/rebus-autofac-module/blob/master/AutofacRegistration/RebusHandlerModule.cs) to the project containing the Rebus handlers, then use Autofac's [assembly scanning](http://docs.autofac.org/en/latest/register/scanning.html) to register the modules like so:

    var b = new ContainerBuilder();
    b.RegisterAssemblyModules(MyAssembly); // MyAssembly contains the handlers.
    c = b.Build();
