using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Engine
{
    public class RoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Heading { get; set; }

        public RoverPosition(int x, int y, Direction heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        public enum Direction
        {
            N=0,
            E=1,
            S=2,
            W=3
        }
    }
}
