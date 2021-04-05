namespace Tfe.NetClient.Test
{
    using System;
    using Xunit;
    using Plans;
    using System.Threading.Tasks;

    public class PlanTest
    {
        [Fact]
        public async Task GetPlanAsyncTest()
        {
            var planId = "plan-1234567890abcdef";

            PlansResponse result = await TestHelper.GetTestClient("Plan/GetPlan").Plan.GetPlanAsync(planId);

            Assert.NotNull(result);
            Assert.Equal(planId, result.Data.Id);
            Assert.Equal(4, result.Data.Attributes.ResourceAdditions);
            Assert.Equal(1, result.Data.Attributes.ResourceChanges);
            Assert.Equal(0, result.Data.Attributes.ResourceDestructions);
            Assert.Equal(new Uri("https://archivist.terraform.io/v1/object/1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef"), result.Data.Attributes.LogReadUrl);
        }
    }
}