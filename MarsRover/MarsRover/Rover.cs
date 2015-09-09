using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Engine
{
    public class Rover
    {
        public RoverPosition Position { get; set; }
        public LandingArea Plateau { get; set; }

        public Rover(LandingArea plateau, RoverPosition initialPosition)
        {
            Plateau = plateau;
            Position = initialPosition;
        }

        public void ProcessInput(string inputCommand)
        {
            foreach (char command in inputCommand)
                ProcessCommand(command);
        }

        private void ProcessCommand(char command)
        {
            switch( command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
            }
        }

        private void TurnLeft()
        {
            if (Position.Heading == RoverPosition.Direction.N)
                Position.Heading = RoverPosition.Direction.W;
            else
            {
                Position.Heading -= 1;
            }
        }

        private void TurnRight()
        {
            if (Position.Heading == RoverPosition.Direction.W)
                Position.Heading = RoverPosition.Direction.N;
            else
            {
                Position.Heading += 1;
            }
        }

        private void Move()
        {
            switch(Position.Heading)
            {
                case RoverPosition.Direction.N:
                    if (Position.Y < Plateau.Depth)
                        Position.Y += 1;
                    break;
                case RoverPosition.Direction.E:
                    if (Position.X < Plateau.Width)
                        Position.X += 1;
                    break;
                case RoverPosition.Direction.S:
                    if (Position.Y > 0)
                        Position.Y -= 1;
                    break;
                case RoverPosition.Direction.W:
                    if (Position.X > 0)
                        Position.X -= 1;
                    break;
            }
        }

    }
}
