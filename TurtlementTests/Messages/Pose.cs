using RobSharper.Ros.MessageEssentials;

namespace TurtlementTests.Messages
{
    [RosMessage("turtlesim/Pose")]
    public class Pose
    {
        /*
            float32 x
            float32 y
            float32 theta

            float32 linear_velocity
            float32 angular_velocity
        */
            
        [RosMessageField("float32", "x", 1)]
        public float x { get; set; }
            
        [RosMessageField("float32", "y", 2)]
        public float y { get; set; }
            
        [RosMessageField("float32", "theta", 3)]
        public float Theta { get; set; }
            
        [RosMessageField("float32", "linear_velocity", 4)]
        public float linear_velocity { get; set; }
            
        [RosMessageField("float32", "angular_velocity", 5)]
        public float angular_velocity { get; set; }
    }
}