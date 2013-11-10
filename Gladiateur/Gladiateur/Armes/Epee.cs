using System;

namespace Gladiateur.Armes
{
	public class Epee : Arme, IAttaquer
	{
		//Constructeur
		public Epee ()
			:base("épée",5,true,false,4,70)
		{
		}
		private static Random rand = new Random();
		//Méthode
		public override bool Attaquer()
		{
			int randomNumber = Random_generate.rInt ();
			Console.WriteLine ("Voilà la valeur de randomNumber de l'épée :");
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

