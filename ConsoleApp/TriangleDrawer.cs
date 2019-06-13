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
            
            List<string> triangle = GenerateRows(padding,size);

            foreach (string row in triangle)
            {
                Console.WriteLine(row);
            }
            
        }


        public List<string> GenerateRows(int padding, int itemCount)
        {
            List<string> rows = new List<string>();
            string row = "";
            if (itemCount > 1)
            {
                var padding2 = padding + 1;
                var itemCount2 = itemCount - 1;
                rows = GenerateRows(padding2, itemCount2);
            }

            
            for (int i = 0; i < padding; i++)
            {
                row = " " + row;
            }
            for (int i = 0; i < itemCount; i++)
            {
                row += "* ";
            }
            rows.Add(row);

            

            return rows;
        }

    }
}
