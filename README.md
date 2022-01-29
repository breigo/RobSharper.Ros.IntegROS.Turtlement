# RobSharper.Ros.IntegROS.Turtlement
Testing playground for writing ROS integration tests with IntegROS.Net


Welcome to the robotic swimming turtlement. 
In this tournament, robotic turtles swim races in a small lake. 
As for all competitive sports events, rules also apply for the turtlement. 
They are described in the next section.


## Turtlement rules

### Environment
The turtlement environment is logically split into different areas which are depicted in the figure below and described hereafter.


#### Waiting area:
Turtles prepare in this area for the race.

#### Lanes:
The lake has three lanes.
Each lane is reserved for one turtle.

#### Start area:
On the left side of the lanes there is a dedicated start area.
Turtles position in thisarea before the race starts.

#### Swim area:
In this area turtles swim laps during the race.

#### Finish area:
The finish area on the right side of the lanes starts with the finish line. 
The raceends here.

#### Turn areas:
The swim area contains two turn areas.
During the race turtles are only allowedto turn inside these areas.

### Race procedure

- Before the race starts turtles are located in the *waiting area*.
- The referee triggers the "ON_YOUR_MARK" command.
    Turtles start swimming to their start positions in their lanes.
- When all turtles are ready, the referee triggers the "GET_SET" command.
    Turtles are expected to calm down and rest on their start positions.
- The referee triggers the "GO" command when all turtles are not moving any more.
    - The race starts and the turtles begin to swim.
    - All turtles swim inside their lanes until they reach the turn area on the other side of the lake (lap 1).
    - If they did not swim the required number of laps they turn around and swim back until reaching the next turn area (lap 2), turn and swim back again (lap 3).
    - The last step is repeated until the turtles have swum the required number of laps.
    - In the last lap the turtles cross the turn area (without turning) and the goal line. The number of laps is always an odd number, so the race ends in the goal area.
    - They stop in the goal area.
- After the last turtle stops in the goal area, the referee triggers the "FINAL_WHISTLE" command and the race is over.
