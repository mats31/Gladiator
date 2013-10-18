using System;
using System.Collections.Generic;
using System.Linq;
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
		private string _returnArmeAttDef;
		private string _returnArmeIni;

		//Constructeur
		public Combat (Gladiateur gla1, Gladiateur gla2)
		{
			this._gla1 = gla1;
			this._gla2 = gla2;
		}

		//Méthode
		public string triArmeAttDef()
		{
			//gla1 - récupère Arme + tri Arme attaque/Arme defense
			foreach (Arme b_arme in this._gla1.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque1.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense1.Add (b_arme);
				}
			}

			//gla2 - récupère Arme + tri Arme attaque/Arme defense
			foreach (Arme b_arme in this._gla2.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque2.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense2.Add (b_arme);
				}
			}

			//Return gla1
			//Return arme attaque
			_returnArmeAttDef = "\nLes armes d\'attaques de " + _gla1.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeAttaque1) {
				_returnArmeAttDef += "\t- "+b_arme.Nom+"\n";
			}
			//Return arme défense
			_returnArmeAttDef += "Les armes de défense de " + _gla1.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeDefense1) {
				_returnArmeAttDef += "\t- "+b_arme.Nom+"\n";
			}

			//return gla2
			//Return arme attaque
			_returnArmeAttDef += "\nLes armes d\'attaques de " + _gla2.Nom + " sont :\n \t- ";
			foreach (Arme b_arme in this._listeArmeAttaque2) {
				_returnArmeAttDef += b_arme.Nom+"\n";
			}
			//Return arme défense
			_returnArmeAttDef += "Les armes de défense de " + _gla2.Nom + " sont :\n";
			foreach (Arme b_arme in this._listeArmeDefense2) {
				_returnArmeAttDef += "\t- "+b_arme.Nom+"\n";
			}

			//Tri ArmeAttaque par initiative
			_listeArmeAttaque1 = (from b_arme in _listeArmeAttaque1
			                      orderby b_arme.Initiative
			                      select b_arme).ToList ();

			_listeArmeAttaque2 = (from b_arme in _listeArmeAttaque2
			                      orderby b_arme.Initiative
			                      select b_arme).ToList ();


			_returnArmeAttDef += "\nArme ayant la meilleur initiative de "+_gla1.Nom+" : ";
			_returnArmeAttDef += _listeArmeAttaque1 [0].Nom+"\n";
			_returnArmeAttDef += "Arme ayant la meilleur initiative de "+_gla2.Nom+" : ";
			_returnArmeAttDef += _listeArmeAttaque2 [0].Nom+"\n";

			return _returnArmeAttDef;
		}


		public string quiCommence()
		{	
			//Qui a la meilleur initiative
			if(_listeArmeAttaque1[0].Initiative > _listeArmeAttaque2[0].Initiative){
				_listeArmeAttaque1[0].Attaquer();
				return _gla1.Nom+" attaque en premier avec "+_listeArmeAttaque1 [0].Nom;
			}
			else if (_listeArmeAttaque1[0].Initiative < _listeArmeAttaque2[0].Initiative){
				_listeArmeAttaque2[0].Attaquer();
				return _gla2.Nom+" attaque en premier avec "+_listeArmeAttaque2[0].Nom;
			}
			else if (_listeArmeAttaque1[0].Initiative == _listeArmeAttaque2[0].Initiative){
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
					_listeArmeAttaque1[0].Attaquer();
					return _gla1.Nom+" attaque en premier avec "+_listeArmeAttaque1 [0].Nom;
				}
				else if (random2>random1){
					_listeArmeAttaque2[0].Attaquer();
					return _gla2.Nom+" attaque en premier avec "+_listeArmeAttaque2[0].Nom;
				}
			}
			return null;
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

				Console.WriteLine("Le gladiateur \"" + _gla1.Nom + "\" a manqué son attaque !");

				if (_listeArmeAttaque2[0].Attaquer() == true) 
				{
					if (_listeArmeDefense1[0].Defendre() == true)
					{

						Console.WriteLine("Le gladiateur \"" + _gla1.Nom + "\" a bloqué l'attaque !");
					}

					_gla1.Vie = 0;
					return("Le gladiateur \"" + _gla2.Nom + "\" a touché son ennemi ! Le gladiateur \"" + _gla1.Nom + "\" est vaincu !");
				}

				Console.WriteLine("Le gladiateur \"" + _gla2.Nom + "\" a manqué son attaque !");
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
