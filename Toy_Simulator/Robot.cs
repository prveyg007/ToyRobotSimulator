using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Simulator
{
    public class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }

        public Robot(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }

        //Command in the Place
        public void Place(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }

        //Command in the Move Movement
        public void Move()
        {
            switch (Facing)
            {
                case Direction.NORTH:
                    if (Y < 4) Y++;
                    break;
                case Direction.EAST:
                    if (X < 4) X++;
                    break;
                case Direction.SOUTH:
                    if (Y > 0) Y--;
                    break;
                case Direction.WEST:
                    if (X > 0) X--;
                    break;
            }
        }

        //Command in the Left Movement
        public void Left()
        {
            switch (Facing)
            {
                case Direction.NORTH:
                    Facing = Direction.WEST;
                    break;
                case Direction.EAST:
                    Facing = Direction.NORTH;
                    break;
                case Direction.SOUTH:
                    Facing = Direction.EAST;
                    break;
                case Direction.WEST:
                    Facing = Direction.SOUTH;
                    break;
            }
        }

        //Command in the Right Movement
        public void Right()
        {
            switch (Facing)
            {
                case Direction.NORTH:
                    Facing = Direction.EAST;
                    break;
                case Direction.EAST:
                    Facing = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    Facing = Direction.WEST;
                    break;
                case Direction.WEST:
                    Facing = Direction.NORTH;
                    break;
            }
        }

        //Command in the Report
        public string Report()
        {
            return $"{X},{Y},{Facing}";
        }
    }
}
