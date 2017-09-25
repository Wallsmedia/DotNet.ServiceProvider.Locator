// \\     |/\  /||
//  \\ \\ |/ \/ ||
//   \//\\/|  \ || 
// Copyright © Alexander Paskhin 2013-2017. All rights reserved.
// Wallsmedia LTD 2015-2017:{Alexander Paskhin}
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Dot NET Dependency Injection ServiceProvider Locator Test

using DotNet.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.Extensions.DependencyInjection.Test
{
    [TestClass]
    public class ServiceProviderLocatorTest
    {
        [TestMethod]
        public void TestStaticNegative()
        {
            Assert.IsNull(ServiceProviderLocator.Default);
            Assert.AreEqual(0,ServiceProviderLocator.Providers.Count);
            Assert.IsNull(ServiceProviderLocator.GetServiceProvider(ServiceProviderLocator.DefaultLocator));
        }

        [TestMethod]
        public void TestStaticPositive()
        {
            ServiceCollection collection = new ServiceCollection();
            ServiceProvider provider = collection.BuildServiceProvider();
            ServiceProviderLocator.RegisterServiceProvider(provider);
            Assert.IsNotNull(ServiceProviderLocator.Default);
            Assert.AreEqual(1, ServiceProviderLocator.Providers.Count);
            Assert.IsNotNull(ServiceProviderLocator.GetServiceProvider(ServiceProviderLocator.DefaultLocator));
        }

    }
}
