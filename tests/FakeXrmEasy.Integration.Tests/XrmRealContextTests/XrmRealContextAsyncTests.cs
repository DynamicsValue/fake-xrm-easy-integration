using System;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Abstractions.Exceptions;
using Microsoft.PowerPlatform.Dataverse.Client;
using Xunit;

namespace FakeXrmEasy.Integration.Tests.XrmRealContextTests;

public class XrmRealContextAsyncTests: FakeXrmEasyTestsBase
    {
        private readonly XrmRealContext _realContext;
        private readonly IOrganizationServiceAsync _serviceAsync;
        private readonly IOrganizationServiceAsync2 _serviceAsync2;

        public XrmRealContextAsyncTests() : base()
        {
            _realContext = new XrmRealContext(_service);
            _serviceAsync = _context.GetAsyncOrganizationService();
            _serviceAsync2 = _context.GetAsyncOrganizationService2();
            _realContext.LicenseContext = FakeXrmEasyLicense.RPL_1_5;
        }

        private class CustomProperty
        {

        }

        [Fact]
        public void Should_return_service_that_was_injected_in_the_constructor()
        {
            Assert.Equal(_service, _realContext.GetOrganizationService());
        }

        [Fact]
        public void Should_retrieve_fake_organization_service() 
        {           
            var ctx = new XrmRealContext(_service, _serviceAsync, _serviceAsync2);
            ctx.LicenseContext = FakeXrmEasyLicense.RPL_1_5;

            Assert.Equal(_service, ctx.GetOrganizationService());
            Assert.Equal(_serviceAsync, ctx.GetAsyncOrganizationService());
            Assert.Equal(_serviceAsync2, ctx.GetAsyncOrganizationService2());
        }

        [Fact]
        public void Should_return_false_if_context_doesnt_have_a_property()
        {
            var ctx = new XrmRealContext(_service, _serviceAsync, _serviceAsync2);
            Assert.False(ctx.HasProperty<CustomProperty>());
        }

        [Fact]
        public void Should_return_true_if_context_does_have_a_property()
        {
            var ctx = new XrmRealContext(_service, _serviceAsync, _serviceAsync2);
            ctx.SetProperty<CustomProperty>(new CustomProperty());
            Assert.True(ctx.HasProperty<CustomProperty>());
        }

        [Fact]
        public void Should_retrieve_property_that_was_previously_set()
        {
            var ctx = new XrmRealContext(_service, _serviceAsync, _serviceAsync2);

            var prop = new CustomProperty();
            ctx.SetProperty<CustomProperty>(prop);

            var retrieved = ctx.GetProperty<CustomProperty>(); 
            Assert.Equal(prop, retrieved);
        }

        [Fact]
        public void Should_return_real_service_client_if_no_fake_service_async_was_set_in_the_constructor()
        {
            var ctx = new XrmRealContext("dummy connection");

            var ex = Assert.Throws<ArgumentException>(() => ctx.GetAsyncOrganizationService());
            Assert.Contains("AuthType is invalid", ex.Message);
        }
        
        [Fact]
        public void Should_return_real_service_client_if_no_fake_service_async2_was_set_in_the_constructor()
        {
            var ctx = new XrmRealContext("dummy connection");

            var ex = Assert.Throws<ArgumentException>(() => ctx.GetAsyncOrganizationService2());
            Assert.Contains("AuthType is invalid", ex.Message);
        }
    }