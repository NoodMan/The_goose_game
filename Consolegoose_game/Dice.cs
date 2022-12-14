using System;
namespace Consolegoose_game
{
	public class Dice
	{
		//proprietes
		private Random random = new Random();


		//methode
		public int Throw()
		{
			return random.Next(1, 6);
        }
		
	}


}

