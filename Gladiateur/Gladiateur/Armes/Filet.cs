using System;

namespace Gladiateur.Armes
{
	public class Filet : Arme, IAttaquer
	{
		//Constructeur
		public Filet ()
			:base("filet",3,true,false,1,30)
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

