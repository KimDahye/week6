using System;

namespace Drawing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DrawingChar ("*", 3, 1);
			DrawingChar ("#", 4, 2);
			DrawingChar ("%", 8, 4);

		}

		public static void DrawingChar(string Character, int level, int gapDiff)
		{
			for (int outer = 1; outer <= level; outer++) {
				for (int inner = 1; inner <= outer*gapDiff; inner++) {
					Console.Write (Character);
				}
				Console.WriteLine ();
			}
			Console.WriteLine ();
		}
	}
}
