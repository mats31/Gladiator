using System;

namespace Gladiateur.Armes
{
	public class Bouclier_rectangulaire : Arme, IDefendre
	{
		//Constructeur
		public Bouclier_rectangulaire ()
			:base("bouclier rectangulaire", 8,false,true,0,30)
		{
		}

		//Méthode
		public void Defendre()
		{

		}
	}
}

