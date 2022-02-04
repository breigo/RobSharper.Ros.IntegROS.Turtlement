using System;
using System.Linq;
using FluentAssertions;
using RobSharper.Ros.IntegROS;
using TurtlementTests.Messages;

namespace TurtlementTests
{
    /// <summary>
    /// In the example scenario (ExampleBag) a turtle is moving
    /// from the left to the right side of the turtlesim simulator.
    /// </summary>
    [RosbagScenario(BagFiles.ExampleBag)]
    public class IntegRosTest1 : ForScenario
    {
        /// <summary>
        /// The simplest of all test cases:
        /// There should have been any message published.
        /// </summary>
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
        
        /// <summary>
        /// Verify that turtle 1 moved from left to right.
        /// </summary>
        [ExpectThat]
        public void Turtle_always_moves_forwards()
        {
            Scenario
                .Messages
                .InTopic<Pose>("/turtle1/pose")
                .Should()
                .BeInAscendingOrder(message => message.Value.x);
        }
    }
}
