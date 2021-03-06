﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiateur.Armes;

namespace Gladiateur
{
    public class Gladiateur
    {
		//Attributs
		private string _nom;
		public string Nom
		{
			get { return this._nom; }
			protected set { this._nom = value; }
		}
        
		private int _point_arme;
		public int PointArme
		{
			get { return this._point_arme; }
			protected set { this._point_arme = value; }
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
		public float PcVictoire
		{
			get { return this._pc_victoire; }
			protected set { this._pc_victoire = value; }
		}
     	
		private List<Arme> _listeArme;
		public List<Arme> ListeArme {
			get {
				return _listeArme;
			}
			private set {
				_listeArme = value;
			}
		}

		private int _vie;
		public int Vie
		{
			get { return this._vie; }
			set { this._vie = value; }
		}
     	
		//Constructeur
        public Gladiateur(string nom)
        {
			this.Nom = nom;
			this.ListeArme = new List<Arme> ();
			this.Vie = 1;
        }

		//Méthode
		public string equipeGlad()
		{

			foreach (Arme b_arme in ListeArme)
			{
				Message.showMessage("Le gladiateur \""+this.Nom+"\" s'équipe avec : "+b_arme.Nom+".");
			}

			return null;
		}

		public void setArme(Arme a)
		{
			this.PointArme += a.Points;

			if (this.PointArme <= 10) {
				this.ListeArme.Add (a);
				Message.showMessage("Le gladiateur "+this.Nom+" s'équipe avec : "+a.Nom+".");
			} else {
				Message.showMessage ("Ce gladiateur possède déjà "+PointArme+" points d'armes");
			}
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
