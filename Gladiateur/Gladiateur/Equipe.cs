using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gladiateur
{
    class Equipe
    {
		//Attributs
		private Joueur _joueur;
		public Joueur Joueur
		{
			get { return this._joueur; }
			protected set { this._joueur = value; }
		}

		private Array _gladiateurs;
		public Array Gladiateurs
		{
			get { return this._gladiateurs; }
			protected set { this._gladiateurs = value; }
		}

        private string _nom;
		public string Nom
		{
			get { return this._nom; }
			protected set { this._nom = value; }
		}

        private string _desc;
		public string Desc
		{
			get { return this._desc; }
			protected set { this._desc = value; }
		}

        private int _match_joue=0;
		public int matchJoue
		{
			get { return this._match_joue; }
			protected set { this._match_joue = value; }
		}

        private int _victoire=0;
		public int Victoire
		{
			get { return this._victoire; }
			protected set { this._victoire = value; }
		}
        private int _defaite=0;
		public int Defaite
		{
			get { return this._defaite; }
			protected set { this._defaite = value; }
		}
        private float _pc_victoire;
		public float pcVictoire
		{
			get { return this._pc_victoire; }
			protected set { this._pc_victoire = value; }
		}
		private List<Gladiateur> _listeGladiateur;
		public List<Gladiateur> ListeGladiateur {
			get {
				return _listeGladiateur;
			}
			set {
				_listeGladiateur = value;
			}
		}

        public Equipe(string nom, string desc)
        {
			this.Nom    = nom;
			this.Desc = desc;
			this.ListeGladiateur = new List<Gladiateur> ();
        }

		//Méthodes
		public string creerGlad()
		{

			foreach (Gladiateur b_gladiateur in ListeGladiateur)
			{
				Console.WriteLine("\""+b_gladiateur.Nom+"\" rejoint l'équipe des "+this.Nom+".");
			}

			return null;
		}
		/*
		//Méthode
        public int joue()
        {
            this.match_joue++;
        }
        public int gagne()
        {
            this.victoire++;
        }
        public int perd()
        {
            this.defaite++;
        }        
        public float pcVictoire()
        {
            this.pc_victoire = (this.victoire/this.match_joue)*100;
        }
        */
		

    }
}
