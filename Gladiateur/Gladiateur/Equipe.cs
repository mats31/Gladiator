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
        private string nom;
        private string desc;
        private int match_joue;
        private int victoire;
        private int defaite;
        private float pc_victoire;

		//Constructeur
        public Equipe(string nom, string desc)
        {

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
