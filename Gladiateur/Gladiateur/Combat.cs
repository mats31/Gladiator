using System;
using Gladiateur.Armes;

namespace Gladiateur
{
	public class Combat
	{
		//Attributs
		private Gladiateur _gla1;
		private Gladiateur _gla2;

		//Constructeur
		public Combat (Gladiateur gla1, Gladiateur gla2)
		{
			this._gla1 = gla1;
			this._gla2 = gla2;
		}

		//Getters-Setters


		//Méthode
		public Gladiateur quiCommence()
		{		
			if(arme1.initiative>arme2.initiative){
				arme1.attaquer();
			}
			else if (arme2.initiative>arme1.initiative){
				arme1.attaquer();
			}
			else if (arme1.initiative == arme2.initiative){
				Random Random1 = new Random();
				int    random1 = Random1.Next();

				Random Random2 = new Random();
				int    random2 = Random2.Next();

				if (random1 == random2) {
					while (random1 == random2) {
						random1 = Random1.Next();
						random2 = Random2.Next();
					}
				}
				else if(random1>random2){
					arme1.attaquer(arme2);
				}
				else if (random2>random1){
					arme2.attaquer(arme1);
				}
			}
		}

*/
	//	public attaque(string armeDef)
	//	{
	//		   25
	//	}

	}
}

