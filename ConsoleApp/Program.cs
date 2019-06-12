using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleDrawer triangleDrawer = new TriangleDrawer();
            GrowingShapeGenerator growingShapeGenerator = new GrowingShapeGenerator(triangleDrawer);

            growingShapeGenerator.Begin(10);

        }
    }
}
