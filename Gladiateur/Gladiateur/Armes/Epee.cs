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

		//Méthode
		public override void Attaquer()
		{

		}

		public override void Defendre()
		{

		}

	}
}

