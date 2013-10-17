using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiateur.Armes;

namespace Gladiateur
{
    class Gladiateur
    {
		//Attributs
		private string _nom;
		public string Nom
		{
			get { return this._nom; }
			protected set { this._nom = value; }
		}
		private List<Arme> _listeArme;
		public List<Arme> ListeArme {
			get {
				return _listeArme;
			}
			set {
				_listeArme = value;
			}
		}
        private int point_arme;
        private int victoire;
        private int defaite;
        private float pc_victoire;
     	
		//Constructeur
        public Gladiateur(string nom)
        {
			this.Nom = nom;
			this.ListeArme = new List<Arme> ();
        }
		/*
        public int gagne()
        {
            this._victoire++;
        }
        public int perd()
        {
            this._defaite++;
        }
        public float pcVictoire()
        {
            this._pc_victoire = (this._victoire/(this._victoire+this._defaite))*100;            
        }*/
    }
}
