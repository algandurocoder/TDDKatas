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
    class MarsRoverTests
    {
        [TestCase(5,7,5,7)]
        [TestCase(0, 0, 1, 1)]
        [TestCase(-5, 0, 1, 1)]
        [TestCase(0, -3, 1, 1)]
        [TestCase(8, -3, 8, 1)]
        [TestCase(-8, 3, 1, 3)]
        public void TestPlateauConstructor(int width, int depth, int expectedWidth, int expectedDepth)
        {
            LandingArea plateau = new LandingArea(width, depth);
            Assert.AreEqual(expectedWidth, plateau.Width);
            Assert.AreEqual(expectedDepth, plateau.Depth);
        }
        
        [Test, TestCaseSource("TestLandRoverSource")]
        public void TestLandRover(RoverPosition landingCoordinates)
        {
            LandingArea plateau = new LandingArea(10, 10);
            plateau.LandRover(landingCoordinates);
            Assert.AreEqual(plateau.Rovers[0].Position.X, landingCoordinates.X);
            Assert.AreEqual(plateau.Rovers[0].Position.Y, landingCoordinates.Y);
            Assert.AreEqual(plateau.Rovers[0].Position.Heading, landingCoordinates.Heading);
        }

        static RoverPosition[] TestLandRoverSource =
        {
            new RoverPosition(1,2, RoverPosition.Direction.S)
        };
    }
}
