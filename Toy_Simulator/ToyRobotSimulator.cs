using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Simulator
{
    public class ToyRobotSimulator
    {
        private Robot robot;

        //Initialize the position
        public ToyRobotSimulator()
        {
            robot = new Robot(-1, -1, Direction.NORTH); // Initialize robot with invalid position
        }

        //Execute the given command Move
        public void ExecuteCommand(string command)
        {
            string[] parts = command.Split(' ');
            string action = parts[0];

            switch (action)
            {
                case "PLACE":
                    string[] args = parts[1].Split(',');
                    int x = int.Parse(args[0]);
                    int y = int.Parse(args[1]);
                    Direction facing = (Direction)Enum.Parse(typeof(Direction), args[2]);
                    if (IsValidPosition(x, y))
                    {
                        robot.Place(x, y, facing);
                    }
                    break;
                case "MOVE":
                    if (IsValidMove())
                    {
                        robot.Move();
                    }
                    break;
                case "LEFT":
                    robot.Left();
                    break;
                case "RIGHT":
                    robot.Right();
                    break;
                case "REPORT":
                    Console.WriteLine(robot.Report());
                    break;
            }
        }
        
       //Check the position is valid given in the command
        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x <= 4 && y >= 0 && y <= 4;
        }

        //Check it is valid move given in the command
        private bool IsValidMove()
        {
            int nextX = robot.X;
            int nextY = robot.Y;

            switch (robot.Facing)
            {
                case Direction.NORTH:
                    nextY++;
                    break;
                case Direction.EAST:
                    nextX++;
                    break;
                case Direction.SOUTH:
                    nextY--;
                    break;
                case Direction.WEST:
                    nextX--;
                    break;
            }

            return IsValidPosition(nextX, nextY);
        }
    }
}
