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

		Random rand = new Random();
		//Méthode
		public override bool Defendre()
		{
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber du bouclier rectandulaire :");
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

