// \\     |/\  /||
//  \\ \\ |/ \/ ||
//   \//\\/|  \ || 
// Copyright © Alexander Paskhin 2013-2017. All rights reserved.
// Wallsmedia LTD 2015-2017:{Alexander Paskhin}
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Dot NET Dependency Injection ServiceProvider Locator

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DotNet.Extensions.DependencyInjection
{
    /// <summary>
    /// Represents the functional logics of service provider locator.
    /// </summary>
    public static class ServiceProviderLocator
    {
        public const string DefaultLocator = "DefaultLocator";
        private static ConcurrentDictionary<string, IServiceProvider> _provides = new ConcurrentDictionary<string, IServiceProvider>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// Registers/updates the service provider.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="name">The registered name.</param>
        public static void RegisterServiceProvider(IServiceProvider serviceProvider, string name = DefaultLocator)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }
            _provides[name] = serviceProvider;
        }

        /// <summary>
        /// Gets a list of registered providers.
        /// </summary>
        public static List<string> Providers => _provides.Keys.ToList();

        /// <summary>
        /// Gets the default registered provider or null
        /// </summary>
        public static IServiceProvider Default
        {
            get
            {
                if (_provides.Keys.Contains(DefaultLocator))
                {
                    return _provides[DefaultLocator];
                }
                return null;
            }
        }

        /// <summary>
        /// Gets provider by name.
        /// </summary>
        /// <param name="name">The provider name.</param>
        /// <returns>Returns provider or null.</returns>
        public static IServiceProvider GetServiceProvider(string name)
        {
            if (_provides.Keys.Contains(name))
            {
                return _provides[name];
            }
            return null;
        }

    }
}
