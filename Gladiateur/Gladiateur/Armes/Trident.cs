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
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber du trident :");
			Console.WriteLine (randomNumber);
			Console.WriteLine ("Voilà la valeur de pcTouche du trident :");
			Console.WriteLine (this.Pc_touche);
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
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber de défense du trident :");
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
	}
}

