using System;
using System.Linq;
using System.Collections.Generic;
using DataverseEntities;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.CodeActivities;
using FakeXrmEasy.CodeActivities.Tests.CodeActivitiesForTesting;
using Xunit;

namespace FakeXrmEasy.Integration.Tests.XrmRealContextTests
{
    public class XrmRealContextCodeActivityTests: FakeXrmEasyTestsBase
    {
        private readonly XrmRealContext _realContext;
        private readonly Account _account;

        public XrmRealContextCodeActivityTests() : base()
        {
            _realContext = new XrmRealContext(_service) 
            { 
                LicenseContext = FakeXrmEasyLicense.RPL_1_5 
            };

            _account = new Account() { Id = Guid.NewGuid() };
        }

        [Fact]
        public void Should_execute_code_activity_against_a_dummy_real_context()
        {
            var inputs = new Dictionary<string, object>()
            {
                { "inputEntity" , _account.ToEntityReference()}
            };

            var wfContext = _realContext.GetDefaultWorkflowContext();
            var outputs = _realContext.ExecuteCodeActivity<CreateTaskActivity>(wfContext, inputs);

            var tasks = _context.CreateQuery<Task>().ToList();
            Assert.Single(tasks);

            Assert.Equal(_account.Id, tasks[0].RegardingObjectId.Id);
        }        
    }
}