using System;

namespace Gladiateur.Armes
{
	public class Bouclier_rectangulaire : Arme, IDefendre
	{
		//Constructeur
		public Bouclier_rectangulaire ()
			:base("bouclier rectangulaire", 8,false,true,0,30)
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

