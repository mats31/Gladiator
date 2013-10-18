using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Joueur
    {
		//Attributs
		private string afficheListeEquipe;
		private string _returnCreation;

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
			private set {
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
			Console.WriteLine ("Le joueur \""+this._alias+"\" est maintenant connecté.");
		}

		//Méthodes
/*		public string connexionJoueurs()
		{
			return("Le joueur \""+this._alias+"\" est maintenant connecté."); 
		}
*/
/*		public string createEquipe()
		{
			_returnCreation = "***** ***** *****\n";
			_returnCreation += "CREATION\n";
			_returnCreation += "***** ***** *****\n";
			//Permet d'obtenir la dernière équipe créé.
			_returnCreation += this._alias + " a créé l'équipe " + this._listeEquipe [this._listeEquipe.Count - 1].Nom + ".";

			return _returnCreation; 
		}
*/
		public void setEquipe(Equipe e)
		{
			if (this.ListeEquipe.Count < 5) {
				this.ListeEquipe.Add (e);
				Console.WriteLine (this._alias + " a créé l'équipe " + this._listeEquipe [this._listeEquipe.Count - 1].Nom + ".");
			} else {
				Console.WriteLine ("Ce joueur possède déjà 5 équipes");
			}
		}

		public Equipe getEquipe(int i)
		{
			return this.ListeEquipe[i];
		}

		public string getListeEquipe()
		{
			foreach (var b_equipe in ListeEquipe) {
				afficheListeEquipe += b_equipe.Nom+" ";
			}
			return afficheListeEquipe;
		}

    }
}
