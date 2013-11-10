using System;

namespace Gladiateur.Armes
{
	public class Petit_bouclier_rond : Arme, IDefendre
	{
		//Constructeur
		public Petit_bouclier_rond ()
			:base("petit bouclier rond",5,false,true,0,20)
		{
		}

		Random rand = new Random();
		//Méthode
		public override bool Defendre()
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

		public override bool Attaquer()
		{
			return false;
		}
	}
}

