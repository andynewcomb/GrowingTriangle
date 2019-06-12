using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp
{
    public class TriangleDrawer : IShapeDrawer
    {

        public TriangleDrawer()
        {
        }

        public void DrawShape(int size)
        {
            int padding = 0;
            
            PrintRow(padding,size);
        }


        public void PrintRow(int padding, int itemCount)
        {
            if (itemCount > 1)
            {
                var padding2 = padding + 1;
                var itemCount2 = itemCount - 1;
                PrintRow(padding2, itemCount2);
            }
            

            string row = "";
            for (int i = 0; i < itemCount; i++)
            {
                row += "* ";
            }

            for (int i = 0; i < padding; i++)
            {
                row = " " + row;
            }
            Console.WriteLine(row);
        }

    }
}
