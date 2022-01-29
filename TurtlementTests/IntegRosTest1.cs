using System;
using System.Linq;
using FluentAssertions;
using RobSharper.Ros.IntegROS;

namespace TurtlementTests
{
    [RosbagScenario(BagFiles.ExampleBag)]
    public class IntegRosTest1 : ForScenario
    {
        [ExpectThat]
        public void Test_case()
        {
            Scenario
                .Messages
                // Add your query here
                .Should()
                // Add your expectation here
                .NotBeEmpty();
        }
        
        [ExpectThat]
        public void Turtle_always_moves_forwards()
        {
            var messages = Scenario
                .Messages
                .InTopic("/turtle*/pose")
                .WithMessageType<Messages.Pose>()
                .Select(message => message.Value.x)
                .Should()
                .BeInAscendingOrder();
        }
    }
}
