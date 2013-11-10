using System;

namespace Gladiateur
{
	static class Random_generate
	{
		private static Random rand = new Random();

		public static int rInt()
		{
			int t = rand.Next(0, 100);
			return t;
		}
	}
}

