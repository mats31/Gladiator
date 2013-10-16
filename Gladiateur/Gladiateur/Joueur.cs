using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Joueur
    {
		//Getters
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
			protected set { this._alias = value; }
		}
		private DateTime _date;
		public DateTime Date
		{
			get { return this._date; }
			protected set { this._date = DateTime.Now; }
		}

<<<<<<< HEAD
		public Joueur(string nom, string prenom, string alias)
=======
		//Constructeur
		private Joueur(string nom, string prenom, string alias)
>>>>>>> 7a64ceb3cfb46d3baf3b23ebd8cdbc82d90dbd84
		{
			this.Nom    = _nom;
			this.Prenom = _prenom;
			this.Alias  = _alias;
			this.Date   = _date;
		}

		//Méthodes
		private void equiperGla()
		{

		}

		private void ordreGla()
		{

		}

		private void creerEquipe()
		{

		}
    }
}
