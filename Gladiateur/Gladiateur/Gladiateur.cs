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
        private string nom;
        private Arme equipement;
        private int point_arme;
        private int victoire;
        private int defaite;
        private float pc_victoire;
     
        public Gladiateur()
        {

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
