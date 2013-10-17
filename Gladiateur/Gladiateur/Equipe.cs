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

        private int _match_joue;
		public int matchJoue
		{
			get { return this._match_joue; }
			protected set { this._match_joue = value; }
		}

        private int _victoire;
		public int Victoire
		{
			get { return this._victoire; }
			protected set { this._victoire = value; }
		}
        private int _defaite;
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

		//Constructeur
        public Equipe(Joueur joueur, string nom, string desc, Array gladiateurs)
        {
			this.Joueur      = joueur;
			this.Nom         = nom;
			this.Desc        = desc;
			this.Gladiateurs = gladiateurs;
        }

		public string creerEquipe()
		{
			return(this.Joueur.Alias+" crée l'équipe \"" + this._nom + "\".\nL'équipe comprend :\n\n"+ this.Gladiateurs); //REGARDE COMMENT ATTEINDRE LES PROPRIETES DE L'OBJET
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
