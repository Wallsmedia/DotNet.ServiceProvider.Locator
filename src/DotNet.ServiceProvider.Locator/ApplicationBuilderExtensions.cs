// \\     |/\  /||
//  \\ \\ |/ \/ ||
//   \//\\/|  \ || 
// Copyright © Alexander Paskhin 2013-2017. All rights reserved.
// Wallsmedia LTD 2015-2017:{Alexander Paskhin}
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Dot NET Dependency Injection ServiceProvider Locator

using Microsoft.AspNetCore.Builder;

namespace DotNet.Extensions.DependencyInjection
{
    /// <summary>
    /// Represents the class extension methods to setup service provider locator from ApplicationBuilder.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Setups  the ServiceProviderLocator with application provider.
        /// </summary>
        /// <param name="app">The class that provides the mechanisms to configure an application's request.</param>
        /// <param name="name">The ServiceProviderLocator name to register.</param>
        /// <returns></returns>
        public static IApplicationBuilder SetupServiceLocator(this IApplicationBuilder app, string name = ServiceProviderLocator.DefaultLocator)
        {
            ServiceProviderLocator.RegisterServiceProvider(app.ApplicationServices, name);
            return app;
        }
    }
}
