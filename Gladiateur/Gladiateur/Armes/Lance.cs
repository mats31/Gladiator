using System;

namespace Gladiateur.Armes
{
	public class Lance: Arme, IAttaquer
	{
		//Constructeur
		public Lance ()
			:base(7,true,false,2,50) 
		{
		}

		//Méthode
		public void Attaque()
		{

		}
	}
}

