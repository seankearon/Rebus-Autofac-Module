# Rebus Autofac Module
An Autofac Module that registers [Rebus](https://github.com/rebus-org/Rebus) handlers by scanning the assembly.

# Usage
Add the 'RebusHandlerModule' to the project containing the Rebus handlers, then use Autofac's [assembly scanning](http://docs.autofac.org/en/latest/register/scanning.html) to register the modules.

    var b = new ContainerBuilder();
    b.RegisterAssemblyModules(MyAssembly); // MyAssembly contains the handlers.
    c = b.Build();
