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
		public void Attaque()
		{

		}
	}
}

