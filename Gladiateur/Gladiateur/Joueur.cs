using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Joueur
    {
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

<<<<<<< HEAD
		public Joueur(string nom, string prenom, string alias)
=======
		//Constructeur
		private Joueur(string nom, string prenom, string alias)
>>>>>>> bb29b4a2d8bfe79da3421b89dbfb1a726068ec8f
		{
			this.Nom    = nom;
			this.Prenom = prenom;
			this.Alias  = alias;
			this.Date   = _date;
		}

		public string creerJoueur()
		{
			return("Le joueur \"" + this._nom + "\" est connecté avec le pseudo "+this._alias);
		}

		private void equiperGla()
		{

		}

		private void ordreGla()
		{

		}
    }
}
