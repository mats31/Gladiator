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
		public void Attaque()
		{

		}
		public void Defendre()
		{
		}
	}
}

