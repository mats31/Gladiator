using System;

namespace Gladiateur.Armes
{
	public class Casque : Arme, IDefendre
	{
		//Constructeur
		public Casque ()
			:base(2,false,true,0,10)
		{
		}

		//Méthode
		public void Defendre()
		{

		}
	}
}

