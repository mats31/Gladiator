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
			//Gla1 - Récupère Arme + Tri ArmeAtt / ArmeDef
			foreach (Arme b_arme in this._gla1.ListeArme) {
				if (b_arme.Attaque == true) {
					_listeArmeAttaque1.Add (b_arme);
				}
				if (b_arme.Defense == true) {
					_listeArmeDefense1.Add (b_arme);
				}
			}

			//Gla2 - Récupère Arme + Tri ArmeAtt / ArmeDef
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
			_returnArmeAttDef = "Les armes d\'attaques de " + _gla1.Nom + " sont \n";
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
			_returnArmeAttDef += "Les armes d\'attaques de " + _gla2.Nom + " sont \n";
			foreach (Arme b_arme in this._listeArmeAttaque2) {
				_returnArmeAttDef += "\t- "+b_arme.Nom+"\n";
			}
			//Return arme défense
			_returnArmeAttDef += "Les armes de défense de " + _gla2.Nom + " sont \n";
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

			_returnArmeAttDef += "Arme ayant la meilleur initiative de gla1 : ";
			_returnArmeAttDef += _listeArmeAttaque1 [0].Nom+"\n";
			_returnArmeAttDef += "Arme ayant la meilleur initiative de gla2 : ";
			_returnArmeAttDef += _listeArmeAttaque2 [0].Nom+"\n";

			return _returnArmeAttDef;
		}

		public string quiCommence()
		{	
			//Qui a la meilleur initiative
			if(_listeArmeAttaque1[0].Initiative < _listeArmeAttaque2[0].Initiative){
				_listeArmeAttaque1[0].Attaquer();
				return _gla1.Nom + " attaque en premier avec " + _listeArmeAttaque1 [0].Nom;
			}
			else if (_listeArmeAttaque1[0].Initiative > _listeArmeAttaque2[0].Initiative){
				_listeArmeAttaque2[0].Attaquer();
				return _gla2.Nom + " attaque en premier avec " + _listeArmeAttaque2 [0].Nom;
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
				else if(random1<random2){
					_listeArmeAttaque1[0].Attaquer();
					return _gla1.Nom + " attaque en premier avec " + _listeArmeAttaque1 [0].Nom;
				}
				else if (random2>random1){
					_listeArmeAttaque2[0].Attaquer();
					return _gla2.Nom + " attaque en premier avec " + _listeArmeAttaque2 [0].Nom;
				}
			}

			return null;
		}

		public string Attaquer()
		{
			int utilise1 = 1;
			int utilise2 = 1;

			while (_gla1.Vie == 1 && _gla2.Vie == 1) 
			{
				if (_gla2.Vie == 1) {
					if (_listeArmeAttaque1 [0].Initiative == 1 && utilise1 == 1|| (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Initiative == 1 && utilise1 == 1)) 
					{
						Message.showMessage(filet(utilise1, _gla1));
						utilise1 = 0;
					}
				}
				if (_gla1.Vie == 1) {
					if (_listeArmeAttaque2 [0].Initiative == 1 && utilise2 == 1|| (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Initiative == 1 && utilise2 == 1))
					{
						Message.showMessage(filet(utilise2, _gla2));
						utilise2 = 0;
					}
				}

				if (_gla2.Vie == 1) {
					if (_listeArmeAttaque1 [0].Initiative == 2 || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Initiative == 2))
					{
						Message.showMessage(lance(_gla1, _gla2));
					}
				}
				if (_gla1.Vie == 1) {
					if (_listeArmeAttaque2 [0].Initiative == 2 || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Initiative == 2))
					{
						Message.showMessage(lance(_gla2, _gla1));
					}
				}

				if (_gla2.Vie == 1) {
					if (_listeArmeAttaque1 [0].Initiative == 3 || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Initiative == 3))
					{
						Message.showMessage(trident(_gla1, _gla2));
					}
				}
				if (_gla1.Vie == 1) {
					if (_listeArmeAttaque2 [0].Initiative == 3 || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Initiative == 3))
					{
						Message.showMessage(trident(_gla2, _gla1));
					}
				}
				
				if (_gla2.Vie == 1) {
					if (_listeArmeAttaque1 [0].Initiative == 4 || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Initiative == 4))
					{
						Message.showMessage(epee(_gla1, _gla2));
					}
				}
				if (_gla1.Vie == 1) {
					if (_listeArmeAttaque2 [0].Initiative == 4 || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Initiative == 4))
					{
						Message.showMessage(epee(_gla2, _gla1));
					}
				}

				if (_gla2.Vie == 1) {
					if (_listeArmeAttaque1 [0].Initiative == 5 || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Initiative == 5))
					{
						Message.showMessage(dague(_gla1, _gla2));
					}
				}
				if (_gla1.Vie == 1) {
					if (_listeArmeAttaque2 [0].Initiative == 5 || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Initiative == 5))
					{
						Message.showMessage(dague(_gla2, _gla1));
					}
				}
			}


			return("Le combat est terminé !");
		}

		public string filet(int utilise, Gladiateur gla)
		{
			if (gla == _gla1 && (_listeArmeAttaque1 [0].Nom == "filet" && _listeArmeAttaque1 [0].Attaquer() == true && utilise == 1) || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Nom == "filet" && _listeArmeAttaque1 [1].Attaquer() == true && utilise == 1))
			{
				_listeArmeAttaque2[0].Pc_touche /= 2;
				if (_listeArmeAttaque2.Count >= 2) 
				{
					_listeArmeAttaque2[1].Pc_touche /= 2;
				}

				return ("Le gladiateur \"" + _gla1.Nom + "\" a touché son ennemi avec son filet ! Le gladiateur \"" + _gla2.Nom + "\" est entravé !");
			}

			if (gla == _gla2 && (_listeArmeAttaque2 [0].Nom == "filet" && _listeArmeAttaque2 [0].Attaquer() == true && utilise == 1) || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Nom == "filet" && _listeArmeAttaque2 [1].Attaquer() == true && utilise == 1))
			{
				_listeArmeAttaque1 [0].Pc_touche /= 2;
				if (_listeArmeAttaque1.Count >= 2) 
				{
					_listeArmeAttaque1[1].Pc_touche /= 2;
				}


				return ("Le gladiateur \"" + _gla2.Nom + "\" a touché son ennemi avec son filet ! Le gladiateur \"" + _gla1.Nom + "\" est entravé !");
			}
			return("Le gladiateur \""+gla.Nom+"\" tente de lancer son filet sur l'ennemi, mais cela échoue !");
		}

		public string lance(Gladiateur gla1, Gladiateur gla2)
		{
			if (gla1 == _gla1) 
			{
				if ((_listeArmeAttaque1 [0].Nom == "lance" && _listeArmeAttaque1 [0].Attaquer () == true) || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Attaquer () == true && _listeArmeAttaque1 [1].Nom == "lance"))
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec sa lance ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}


				if (_listeArmeDefense2[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[0].Nom+" !");
				}

				if (_listeArmeDefense2.Count >= 2 && _listeArmeDefense2[1].Defendre() == true && _listeArmeDefense2[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			if (gla1 == _gla2) 
			{
				if ((_listeArmeAttaque2 [0].Nom == "lance" && _listeArmeAttaque2 [0].Attaquer () == true)  || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Attaquer () == true && _listeArmeAttaque2 [1].Nom == "lance"))
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec sa lance ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}


				if (_listeArmeDefense1[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense1[0].Nom+" !");
				}

				if (_listeArmeDefense1.Count >= 2 && _listeArmeDefense2[1].Defendre() == true && _listeArmeDefense1[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense1[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			return ("");
		}

		public string trident(Gladiateur gla1, Gladiateur gla2)
		{
			if (gla1 == _gla1) 
			{
				if ((_listeArmeAttaque1 [0].Nom == "trident" && _listeArmeAttaque1 [0].Attaquer () == true) || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Attaquer () == true && _listeArmeAttaque1 [1].Nom == "trident")) {
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec son trident ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense2 [0].Defendre () == true) {

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur " + gla1.Nom + " avec son " + _listeArmeDefense2 [0].Nom + " !");
				}

				if (_listeArmeDefense2.Count >= 2 && _listeArmeDefense2 [1].Defendre () == true && _listeArmeDefense2 [0].Defendre () == false) {

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur " + gla1.Nom + " avec son " + _listeArmeDefense2 [1].Nom + " !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			if (gla1 == _gla2) 
			{
				if ((_listeArmeAttaque2 [0].Nom == "trident" && _listeArmeAttaque2 [0].Attaquer () == true) || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Attaquer () == true && _listeArmeAttaque2 [1].Nom == "trident")) {
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec son trident ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense1 [0].Defendre () == true) {

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur " + _gla1.Nom + " avec son " + _listeArmeDefense1 [0].Nom + " !");
				}

				if (_listeArmeDefense1.Count >= 2 && _listeArmeDefense2 [1].Defendre () == true && _listeArmeDefense1 [0].Defendre () == false) {

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur " + gla1.Nom + " avec son " + _listeArmeDefense1 [1].Nom + " !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			return ("");
		}

		public string epee(Gladiateur gla1, Gladiateur gla2)
		{
			if (gla1 == _gla1) 
			{
				if ((_listeArmeAttaque1 [0].Nom == "épée" && _listeArmeAttaque1 [0].Attaquer () == true) || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Attaquer () == true && _listeArmeAttaque1 [1].Nom == "épée")) 
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec son épée ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense2[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[0].Nom+" !");
				}

				if (_listeArmeDefense2.Count >= 2 && _listeArmeDefense2[1].Defendre() == true && _listeArmeDefense2[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			if (gla1 == _gla2) 
			{
				if ((_listeArmeAttaque2 [0].Nom == "épée" && _listeArmeAttaque2 [0].Attaquer () == true) || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Attaquer () == true && _listeArmeAttaque2 [1].Nom == "épée")) 
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec son épée ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense1[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[0].Nom+" !");
				}

				if (_listeArmeDefense1.Count >= 2 && _listeArmeDefense1[1].Defendre() == true && _listeArmeDefense1[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense1[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}	

			return ("");
		}

		public string dague(Gladiateur gla1, Gladiateur gla2)
		{
			if (gla1 == _gla1) 
			{
				if ((_listeArmeAttaque1 [0].Nom == "dague" && _listeArmeAttaque1 [0].Attaquer () == true) || (_listeArmeAttaque1.Count >= 2 && _listeArmeAttaque1 [1].Attaquer () == true && _listeArmeAttaque1 [1].Nom == "dague")) 
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec sa dague ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense2[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[0].Nom+" !");
				}

				if (_listeArmeDefense2.Count >= 2 && _listeArmeDefense2[1].Defendre() == true && _listeArmeDefense2[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense2[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			if (gla1 == _gla2) 
			{
				if ((_listeArmeAttaque2 [0].Nom == "dague" && _listeArmeAttaque2 [0].Attaquer () == true) || (_listeArmeAttaque2.Count >= 2 && _listeArmeAttaque2 [1].Attaquer () == true && _listeArmeAttaque2 [1].Nom == "dague")) 
				{
					gla2.Vie = 0;
					return("Le gladiateur \"" + gla1.Nom + "\" a touché son ennemi avec sa dague ! Le gladiateur \"" + gla2.Nom + "\" est vaincu !");
				}

				if (_listeArmeDefense1[0].Defendre() == true)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense1[0].Nom+" !");
				}

				if (_listeArmeDefense1.Count >= 2 && _listeArmeDefense1[1].Defendre() == true && _listeArmeDefense1[0].Defendre() == false)
				{

					return("Le gladiateur \"" + gla2.Nom + " a bloqué l'attaque du gladiateur "+gla1.Nom+" avec son "+_listeArmeDefense1[1].Nom+" !");
				}

				return("Le gladiateur \"" + gla1.Nom + "\" a manqué son attaque !");
			}

			return ("");
		}
	}
}

