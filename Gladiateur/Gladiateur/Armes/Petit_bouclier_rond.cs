using System;

namespace Gladiateur.Armes
{
	public class Petit_bouclier_rond : Arme, IDefendre
	{
		//Constructeur
		public Petit_bouclier_rond ()
			:base("petit bouclier rond",5,false,true,0,20)
		{
		}

		//Méthode
		public void Defendre()
		{

		}
	}
}

