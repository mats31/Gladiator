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

		Random rand = new Random();
		//Méthode
		public override bool Attaquer()
		{
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber de la dague :");
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

		public override bool Defendre()
		{
			return false;
		}
	}
}

