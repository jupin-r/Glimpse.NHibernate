﻿using System;
using System.Reflection;
using System.Reflection.Emit;
using Glimpse.NHibernate.Inspector.Core.NHibernateDbDriverWrapper;
using Xunit;

namespace Glimpse.NHibernate.Test
{
    public class When_the_GlimpseDbDriverFactory_is_told_to_GetDbDriverType_with_no_profiler_code
    {
        [Fact]
        public void It_should_return_null()
        {
            // Arrange
            var nhibernateAssembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("NHibernate") { Version = new Version(1, 0, 0, 0) }, AssemblyBuilderAccess.ReflectionOnly);
            var glimpseDbDriverFactory = new GlimpseDbDriverFactory();

            // Act
            var result = glimpseDbDriverFactory.GetDbDriverType(nhibernateAssembly);

            // Assert
            Assert.Null(result);
        }
    }
}