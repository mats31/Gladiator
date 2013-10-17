using System;

namespace Gladiateur.Armes
{
	public class Lance: Arme, IAttaquer
	{
		//Constructeur
		public Lance ()
			:base("lance",7,true,false,2,50) 
		{
		}

		//Méthode
		public void Attaque()
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

