using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook.Drawing
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point() { }
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
