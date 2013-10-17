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

		//Méthode
		public void Defendre()
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
		}
	}
}

