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
			return false;
		}
	}
}

