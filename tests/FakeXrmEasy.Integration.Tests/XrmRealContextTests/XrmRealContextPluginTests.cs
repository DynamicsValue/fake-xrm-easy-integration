using System;
using System.Linq;
using System.Reflection;
using DataverseEntities;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Integration.Tests.PluginsForTesting;
using FakeXrmEasy.Plugins;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace FakeXrmEasy.Integration.Tests.XrmRealContextTests
{
    public class XrmRealContextPluginTests: FakeXrmEasyTestsBase
    {
        private readonly XrmRealContext _realContext;

        public XrmRealContextPluginTests(): base()
        {
            _realContext = new XrmRealContext(_service);
            _realContext.LicenseContext = FakeXrmEasyLicense.RPL_1_5;
        }

        [Fact]
        public void Should_execute_plugin_with_real_context()
        {
            _context.EnableProxyTypes(Assembly.GetAssembly(typeof(Task)));

            var guid1 = Guid.NewGuid();
            var target = new Entity("account") { Id = guid1 };

            ParameterCollection inputParameters = new ParameterCollection();
            inputParameters.Add("Target", target);

            ParameterCollection outputParameters = new ParameterCollection();
            outputParameters.Add("id", guid1);

            _realContext.ExecutePluginWith<FollowupPlugin>(inputParameters, outputParameters, null, null);

            //The plugin creates a followup activity, check that that one exists
            var tasks = (from t in _context.CreateQuery<Task>()
                select t).ToList();

            Assert.Single(tasks);
            Assert.Equal("Send e-mail to the new customer.", tasks[0].Subject);
            Assert.Equal(guid1, tasks[0].RegardingObjectId.Id);
        }        
    }
}