using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp;
using NUnit.Framework;

namespace Tests.UnitTests
{
    [TestFixture]
    public class TriangleDrawerTests
    {
        [Test]
        public void DrawShape_Size1_OneRow()
        {
            //arrange
            var triangleDrawer = new TriangleDrawer();

            //act
            var rows = triangleDrawer.GenerateRows(0,1);

            //assert
            Assert.AreEqual(1,rows.Count);
            StringAssert.AreEqualIgnoringCase("* ",rows[0]);


        }

        [Test]
        public void DrawShape_Size3_3Rows()
        {
            //arrange
            var triangleDrawer = new TriangleDrawer();

            //act
            var rows = triangleDrawer.GenerateRows(0, 2);

            //assert
            Assert.AreEqual(2, rows.Count);

            var expectedRow1 = @" * ";
            var expectedRow2 = @"* * ";
            StringAssert.AreEqualIgnoringCase(expectedRow1, rows[0]);
            StringAssert.AreEqualIgnoringCase(expectedRow2, rows[1]);


        }

    }
}
