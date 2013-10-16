using System;

namespace Gladiateur.Armes
{
	public class Dague : Arme, IAttaquer
	{
		//Constructeur
		public Dague ()
			:base(2,true,false,5,60)
		{
		}

		//Méthode
		public void Attaque()
		{

		}
	}
}

