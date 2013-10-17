using System;
using System.Collections.Generic;

using Gladiateur.Armes;

namespace Gladiateur
{
	public class Combat
	{/*
		//Attributs
		private Gladiateur _gla1;
		private Gladiateur _gla2;
		private List<Arme> _listeArmeAttaque  = new List<Arme> ();
		private List<Arme> _listeArmeDefense  = new List<Arme> ();

		//Constructeur
		public Combat (Gladiateur gla1, Gladiateur gla2)
		{
			this._gla1 = gla1;
			this._gla2 = gla2;
		}

		//Méthode
		public string quiCommence()
		{	
			//this._gla1.ListeArme[0]

			//Récupère arme
			foreach (Arme b_arme in this._gla1.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense.Add (b_arme);
				}
			}

			//Affiche arme attaque
			Console.WriteLine ("Les armes d\'attaques de " + _gla1.Nom + " sont \n");
			foreach (Arme b_arme in this._listeArmeAttaque) {
				Console.WriteLine (b_arme+"\n");
			}

			//Affiche arme défense
			Console.WriteLine ("Les armes de défense de " + _gla1.Nom + " sont \n");
			foreach (Arme b_arme in this._listeArmeDefense) {
				Console.WriteLine (b_arme+"\n");
			}
	
		}








			/*	
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
<<<<<<< HEAD
			*/
		
=======
		}

	//	public attaque(string armeDef)
	//	{
	//		   25
	//	}
*/ 
>>>>>>> ee30f8079f782a62752175fc312cf5aede122ce0
	}
}

