using System;

namespace Gladiateur.Armes
{
	public class Lance: Arme, IAttaquer
	{
		//Constructeur
		public Lance ()
			:base("lance",7,true,false,2,50) 
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

