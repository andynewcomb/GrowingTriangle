using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ConsoleApp;
using Moq;
using NUnit.Framework;

namespace Tests.UnitTests
{
    [TestFixture]
    class GrowingShapeGeneratorTests
    {
        [Test]
        public void Begin_10_CallsDrawShape10Times()
        {
            //arrange
            var mockShapeDrawer = new Mock<IShapeDrawer>();
            mockShapeDrawer.Setup(s => s.DrawShape(It.IsAny<int>())).Verifiable();
            var growingShapeGenerator = new GrowingShapeGenerator(mockShapeDrawer.Object);

            //act
            growingShapeGenerator.Begin(10);

            //assert
            mockShapeDrawer.Verify(s=>s.DrawShape(It.IsAny<int>()),Times.Exactly(10));
        }

        [Test]
        public void Begin_10_Takes10Seconds()
        {
            //arrange
            var mockShapeDrawer = new Mock<IShapeDrawer>();
            var growingShapeGenerator = new GrowingShapeGenerator(mockShapeDrawer.Object);

            //act
            var watch = Stopwatch.StartNew();
            growingShapeGenerator.Begin(10);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            
            //assert
            Assert.IsTrue(elapsedMs > 10000);
            Assert.IsTrue(elapsedMs < 110000);

        }

    }
}
