using RobSharper.Ros.MessageEssentials;

namespace TurtlementTests.Messages
{
    [RosMessage("turtlement/RaceCommand")]
    public class RaceCommand
    {
        public enum CommandType
        {
            ON_YOUR_MARK = 1,
            GET_SET = 2,
            GO = 3,
            FINAL_WHISTLE = 4
        };

        [RosMessageField("uint8", "command", 1)]
        public CommandType command { get; set; }

        [RosMessageField("uint8", "laps", 1)]
        public int laps { get; set; }
    }
}