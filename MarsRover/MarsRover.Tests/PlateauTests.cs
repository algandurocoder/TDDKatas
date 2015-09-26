using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsRover.Engine;

namespace MarsRover.Tests
{
    [TestFixture]
    class PlateauTests
    {
        #region Constructor Tests
        [Test]
        public void WidthAndDepthShouldMatch()
        {
            int width = 5;
            int depth = 7;
            LandingArea plateau = new LandingArea(width, depth);
            Assert.That(plateau.Width, Is.EqualTo(width));
            Assert.That(plateau.Depth, Is.EqualTo(depth));
        }

        [Test]
        public void WidthShouldBeOne()
        {
            int width = 0;
            int depth = 7;
            LandingArea plateau = new LandingArea(width, depth);
            Assert.That(plateau.Width, Is.EqualTo(1));
        }

        [Test]
        public void DepthShouldBeOne()
        {
            int width = 5;
            int depth = 0;
            LandingArea plateau = new LandingArea(width, depth);
            Assert.That(plateau.Depth, Is.EqualTo(1));
        }
        #endregion

        #region Test Landing a Rover

        [Test]
        public void ARoverShouldHaveLanded()
        {
            LandingArea plateau = new LandingArea(10, 10);
            RoverPosition landingCoordinates = new RoverPosition(1, 2, RoverPosition.Direction.S);

            plateau.LandRover(landingCoordinates);
            Rover landedRover = plateau.Rovers.FirstOrDefault();

            Assert.That(landedRover, Is.Not.Null);
        }

        [Test]
        public void CoordinatesAndHeadingShouldMatch()
        {
            LandingArea plateau = new LandingArea(10, 10);
            RoverPosition landingCoordinates = new RoverPosition(1, 2, RoverPosition.Direction.S);

            plateau.LandRover(landingCoordinates);
            Rover landedRover = plateau.Rovers.FirstOrDefault();

            Assert.That(landedRover.Position.X, Is.EqualTo(landingCoordinates.X));
            Assert.That(landedRover.Position.Y, Is.EqualTo(landingCoordinates.Y));
            Assert.That(landedRover.Position.Heading, Is.EqualTo(landingCoordinates.Heading));
        }

        [Test]
        public void RoverShouldContainReferenceToLandingArea()
        {
            LandingArea plateau = new LandingArea(10, 10);
            RoverPosition landingCoordinates = new RoverPosition(1, 2, RoverPosition.Direction.S);
    
            plateau.LandRover(landingCoordinates);
            Rover landedRover = plateau.Rovers.FirstOrDefault();

            Assert.That(landedRover.Plateau, Is.SameAs(plateau));
        }

        [Test]
        public void ShouldThrowExceptionIfLandingOutOfBounds()
        {
            LandingArea plateau = new LandingArea(10, 10);
            RoverPosition landingCoordinates = new RoverPosition(1, 20, RoverPosition.Direction.S);

            Assert.That(() => plateau.LandRover(landingCoordinates), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        #endregion
    }
}
