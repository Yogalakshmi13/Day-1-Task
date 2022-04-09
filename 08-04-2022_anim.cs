using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class anim
    {
		static int numbergoat(int Eyes, int Legs)
		{
			int Tot = 0;
			Tot = (Legs) - (Eyes - 1);
			int Total = Tot / 2;
			return Total;
		}

		public static void Main()
		{
			int Eyes = 52, Legs = 80;
			int Goat = numbergoat(Eyes, Legs);
			Console.WriteLine("Number of Goats is:" + Goat);
			Console.WriteLine("Number of Ducks is:" + (Goat - 2));
		}
	}
	}
