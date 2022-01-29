namespace TurtlementTests
{
    public class BagFiles
    {
        private const string BasePath = "Bags/";

        // Example ROSBAG
        public const string ExampleBag = BasePath + "my-recorded-example-bag.bag";
        
        // Turtlement Training ROSBAGs
        public const string One_turtle_one_lap = BasePath + "OK/turtlement_t1_l1__2022-01-26-19-14-52.bag";
        public const string One_turtle_three_laps = BasePath + "OK/turtlement_t1_l3__2022-01-26-19-18-53.bag";
    }
}