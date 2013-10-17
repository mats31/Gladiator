using System;

namespace Gladiateur.Armes
{
	public class Dague : Arme, IAttaquer
	{
		//Constructeur
		public Dague ()
			:base("dague",2,true,false,5,60)
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

