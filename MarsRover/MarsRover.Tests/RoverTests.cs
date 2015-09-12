using MarsRover.Engine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    [TestFixture]
    class RoverTests
    {
        
        Rover _testRover;
        private void InitializeRoverBottomLeft()
        {
            LandingArea _plateau = new LandingArea(10, 10);
            RoverPosition landingCoordinates = new RoverPosition(1, 1, RoverPosition.Direction.N);
            _plateau.LandRover(landingCoordinates);
            _testRover = _plateau.Rovers.FirstOrDefault();
        }

        #region Rotation Tests

        [Test]
        public void ShouldFaceEast()
        {
            InitializeRoverBottomLeft();
            _testRover.Position.Heading = RoverPosition.Direction.N;

            _testRover.ProcessInput("R");
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.E));
        }

        [Test]
        public void ShouldFaceWest()
        {
            InitializeRoverBottomLeft();
            _testRover.Position.Heading = RoverPosition.Direction.N;

            _testRover.ProcessInput("L");
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.W));
        }


        [Test]
        public void ShouldFaceSouth()
        {
            InitializeRoverBottomLeft();
            _testRover.Position.Heading = RoverPosition.Direction.N;

            _testRover.ProcessInput("LL");
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.S));
        }

        [Test]
        public void ShouldFaceNorth()
        {
            InitializeRoverBottomLeft();
            _testRover.Position.Heading = RoverPosition.Direction.S;

            _testRover.ProcessInput("RR");
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.N));
        }

        #endregion

        #region Movement Tests
        [Test]
        public void ShouldMoveUp()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("M");

            Assert.That(_testRover.Position.X, Is.EqualTo(1));
            Assert.That(_testRover.Position.Y, Is.EqualTo(2));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.N));
        }

        [Test]
        public void ShouldMoveTo31E()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("MRMRMLM");

            Assert.That(_testRover.Position.X, Is.EqualTo(3));
            Assert.That(_testRover.Position.Y, Is.EqualTo(1));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.E));
        }

        [Test]
        public void ShouldMoveTo33N()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("MMRMMRMRRM");

            Assert.That(_testRover.Position.X, Is.EqualTo(3));
            Assert.That(_testRover.Position.Y, Is.EqualTo(3));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.N));
        }

        [Test]
        public void ShouldNotGoOffBoundsWest()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("LM");

            Assert.That(_testRover.Position.X, Is.EqualTo(1));
            Assert.That(_testRover.Position.Y, Is.EqualTo(1));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.W));
        }

        [Test]
        public void ShouldNotGoOffBoundsSouth()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("LLM");

            Assert.That(_testRover.Position.X, Is.EqualTo(1));
            Assert.That(_testRover.Position.Y, Is.EqualTo(1));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.S));
        }

        [Test]
        public void ShouldNotGoOffBoundsNorth()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("MMMMMMMMMM");

            Assert.That(_testRover.Position.X, Is.EqualTo(1));
            Assert.That(_testRover.Position.Y, Is.EqualTo(10));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.N));
        }

        [Test]
        public void ShouldNotGoOffBoundsEast()
        {
            InitializeRoverBottomLeft();
            _testRover.ProcessInput("RMMMMMMMMMM");

            Assert.That(_testRover.Position.X, Is.EqualTo(10));
            Assert.That(_testRover.Position.Y, Is.EqualTo(1));
            Assert.That(_testRover.Position.Heading, Is.EqualTo(RoverPosition.Direction.E));
        }
        #endregion
    }
}
