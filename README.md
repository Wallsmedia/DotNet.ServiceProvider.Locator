# DotNet.Di.ServiceProvider.Locator

Static Dependency Injection service provider locator for complex web/plain applications.

https://www.nuget.org/packages/DotNet.ServiceProvider.Locator

Example for Rest Web API application:
``` C#

public void Configure(IApplicationBuilder app)
{
 ...

 // Register as default
 ServiceProviderLocator.RegisterServiceProvider(app.ApplicationServices);

...
}

or 

public void Configure(IApplicationBuilder app)
{
...

// Register with name default

string name = "WebHostAppServices";
ServiceProviderLocator.RegisterServiceProvider(app.ApplicationServices,name);

...
}
```


Example for a plain application:
``` C#

   ServiceCollection collection = new ServiceCollection();
   // Setup collection of the services

   // Register provider with locator
   ServiceProvider provider = collection.BuildServiceProvider();
   ServiceProviderLocator.RegisterServiceProvider(provider);

```


