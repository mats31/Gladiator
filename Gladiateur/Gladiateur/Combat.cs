using System;
using System.Collections.Generic;
using Gladiateur.Armes;

namespace Gladiateur
{
	public class Combat
	{
		//Attributs
		private Gladiateur _gla1;
		private Gladiateur _gla2;
		private List<Arme> _listeArmeAttaque1  = new List<Arme> ();
		private List<Arme> _listeArmeDefense1  = new List<Arme> ();
		private List<Arme> _listeArmeAttaque2  = new List<Arme> ();
		private List<Arme> _listeArmeDefense2  = new List<Arme> ();
		private string _returnMagique;

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

			//Récupère arme gla1
			foreach (Arme b_arme in this._gla1.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque1.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense1.Add (b_arme);
				}
			}

			//Récupère arme gla2
			foreach (Arme b_arme in this._gla2.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque2.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense2.Add (b_arme);
				}
			}

			//Return arme attaque
			_returnMagique = "Les armes d\'attaques de " + _gla1.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeAttaque1) {
				_returnMagique += b_arme.Nom+"\n";
			}
			//Return arme défense
			_returnMagique += "Les armes de défense de " + _gla1.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeDefense1) {
				_returnMagique += b_arme.Nom+"\n";
			}

			//Return arme attaque
			_returnMagique = "Les armes d\'attaques de " + _gla2.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeAttaque2) {
				_returnMagique += b_arme.Nom+"\n";
			}
			//Return arme défense
			_returnMagique += "Les armes de défense de " + _gla2.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeDefense2) {
				_returnMagique += b_arme.Nom+"\n";
			}

			//returnMagique
			return _returnMagique;
		}

		public string Attaquer()
		{
			if (_listeArmeAttaque1[0].Attaquer() == true) 
			{
				if (_listeArmeDefense2[0].Defendre() == true)
				{

					return("Le gladiateur \"" + _gla2.Nom + "\" a bloqué l'attaque !");
				}

				return("Le gladiateur \"" + _gla1.Nom + "\" a touché son ennemi !");
			}

			return("Le gladiateur \"" + _gla1.Nom + "\" a manqué son attaque !");
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

			*/
		


	}
}