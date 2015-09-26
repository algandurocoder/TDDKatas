using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Engine
{
    public class LandingArea
    {
        private int _width=1;
        public int Width{ get { return _width; } }
        private int _depth=1;
        public int Depth{ get { return _depth; }  }
        public LandingArea(Int32 width, Int32 depth)
        {
            if(width > 0)
                _width = width;

            if(depth>0)
                _depth = depth;
        }

        private List<Rover> _Rovers = new List<Rover>();
        public List<Rover> Rovers { get { return _Rovers; } }

        public void LandRover(RoverPosition landingCoordinates) {
            if (!CoordinatesAreWithinLimits(landingCoordinates))
                throw new ArgumentOutOfRangeException("landingCoordinates");

            Rover newRover = new Rover(this, landingCoordinates);
            Rovers.Add(newRover);
        }

        private Boolean CoordinatesAreWithinLimits(RoverPosition coordinates)
        {
            if (coordinates.X > Width)
                return false;
            else if (coordinates.Y > Depth)
                return false;
            else
                return true;
        }

    }
}
