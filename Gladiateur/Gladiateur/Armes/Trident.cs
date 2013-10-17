using System;

namespace Gladiateur.Armes
{
	public class Trident : Arme, IAttaquer, IDefendre
	{
		//Constructeur
		public Trident ()
			:base("trident",7,true,true,3,40) 
		{
		}

		//Méthode
		public override bool Attaquer()
		{
			Random rand = new Random();
			int randomNumber = rand.Next (0, 100);

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
		public override bool Defendre()
		{
			Random rand = new Random();
			int randomNumber = rand.Next (0, 100);

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
	}
}

