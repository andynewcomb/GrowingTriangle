using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp
{
    public class GrowingShapeGenerator
    {
        private readonly IShapeDrawer _shapeDrawer;
        private static Timer aTimer;

        public GrowingShapeGenerator(IShapeDrawer shapeDrawer)
        {
            _shapeDrawer = shapeDrawer;
        }

        public int IntervalInSeconds { get; set; }
        
        public void Begin(int iterations)
        {
            for (int i = 1; i <= iterations; i++)
            {
                Task.Delay(1000).Wait();
                _shapeDrawer.DrawShape(i);
            }
        }



    }
}
