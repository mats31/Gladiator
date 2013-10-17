﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Joueur
    {
		//Getters-Setters
		private string _nom;
		public string Nom
		{
			get { return this._nom; }
			protected set { this._nom = value; }
		}
		private string _prenom;
		public string Prenom
		{
			get { return this._prenom; }
			protected set { this._prenom = value; }
		}
		private string _alias;
		public string Alias
		{
			get { return this._alias; }
			set { this._alias = value; }
		}
		private DateTime _date;
		public DateTime Date
		{
			get { return this._date; }
			protected set { this._date = DateTime.Now; }
		}
		private List<Equipe> _listeEquipe;
		public List<Equipe> ListeEquipe {
			get {
				return _listeEquipe;
			}
			set {
				_listeEquipe = value;
			}
		}

		//Constructeur
		public Joueur(string nom, string prenom, string alias)
		{
			this.Nom    = nom;
			this.Prenom = prenom;
			this.Alias  = alias;
			this.Date   = _date;
			this.ListeEquipe = new List<Equipe> ();
		}
    }
}
