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

		Random rand = new Random();
		//Méthode
		public override bool Attaquer()
		{
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
			return false;
		}
	}
}

