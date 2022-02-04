using System;
using System.Linq;
using FluentAssertions;
using RobSharper.Ros.IntegROS;
using TurtlementTests.Messages;

namespace TurtlementTests
{
    [RosbagScenario((BagFiles.One_turtle_one_lap))]
    [RosbagScenario((BagFiles.One_turtle_three_laps))]
    public class TurtlementTrainingTests : ForScenario
    {
        #region Helpers

        /// <summary>
        /// Turtle 1 publishes its pose on this topic.
        /// </summary>
        public const string TurtlePosesTopic = "/turtle1/pose";
        
        /// <summary>
        /// The referee publishes race commands on this topic.
        /// </summary>
        public const string RaceCommandsTopic = "/race/command";
        
        /// <summary>
        /// Returns the first race command massage containing the given race command type.
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Wrapped RaceCommand message or null, if not found</returns>
        public IRecordedMessage<RaceCommand> GetCommandMessage(RaceCommand.CommandType command)
        {
            return Scenario.Messages
                .InTopic<RaceCommand>(RaceCommandsTopic)
                .FirstOrDefault(msg => msg.Value.command == command);
        }

        #endregion
        
        /*
         * Task 1
         * Verify that race commands are issued in the correct order.
         *      1) ON_YOUR_MARK
         *      2) GET_SET
         *      3) GO
         *      4) FINAL_WHISTLE
         *
         * Race commands are published on the topic "/race/command" with type RaceCommand.
         *
         * Hints for implementation:
         *  - Filter
         *      - RaceCommand messages in topic /race/command
         *  - Verify
         *      - Check order of values
         */
        [ExpectThat(Skip = "Not implemented")]
        public void Race_commands_are_issued_in_the_correct_order()
        {
            throw new NotImplementedException();
        }

        /*
         * Task 2
         * Verify that the turtle is inside the lane barriers during the race.
         * During the race means from the time, the referee issues the GET_SET command until the FINAL_WHISTLE is blown.
         *
         * Hints for implementation:
         *  - Filter
         *      - Pose messages in topic /turtle1/pose
         *      - After GET_SET command and
         *      - Before FINAL_WHISTLE command
         *  - Verify
         *      - Check if the resulting messages only contain poses with y value between 0 and 3
         */
        [ExpectThat(Skip = "Not implemented")]
        public void Turtle_is_in_its_lane_anytime_during_the_race()
        {

            throw new NotImplementedException();
        }


        /*
         * Task 3
         * Verify, that the turtle is inside the start area between the commands GET_SET and GO.
         * 
         * Hints for implementation:
         *  - Filter
         *      - Pose messages in topic /turtle1/pose
         *      - After GET_SET command message and
         *      - Before GO command message
         *  - Verify
         *      - Check if the resulting messages only contain poses with y value between 0 and 3
         */
        [ExpectThat(Skip = "Not implemented")]
        public void Turtle_is_in_start_area_between_get_set_and_go()
        {
            throw new NotImplementedException();
        }

        /*
         * Task4
         * Verify, that the turtle doesn't jump the gun.
         * The turtle is not allowed to move shortly before the GO command.
         * 
         * Hints for implementation:
         *  - Filter
         *      - Pose messages in topic /turtle1/pose
         *      - Only messages before GO command
         *      - Last message from the result
         *  - Verify
         *      - linear_velocity == 0
         *      - angular_velocity == 0
         */
        [ExpectThat(Skip = "Not implemented")]
        public void Turtle_does_not_jump_the_gun()
        {
            throw new NotImplementedException();
        }
    }
}