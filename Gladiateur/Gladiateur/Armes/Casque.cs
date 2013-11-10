using System;

namespace Gladiateur.Armes
{
	public class Casque : Arme, IDefendre
	{
		//Constructeur
		public Casque ()
			:base("casque",2,false,true,0,10)
		{
		}

		private static Random rand = new Random();
		//Méthode
		public override bool Defendre() 
		{
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber du casque :");
			Console.WriteLine (randomNumber);
			if (Pc_touche >= randomNumber) 
			{
				return true;
			}

			if (Pc_touche < randomNumber) 
			{
				return false;
			}

			return false;
		}

		public override bool Attaquer()
		{
			return false;
		}
	}
}

