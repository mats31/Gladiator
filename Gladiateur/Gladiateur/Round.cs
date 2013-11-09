using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Round
    {
        //CE QU'ON DOIT FAIRE MATHOU :)
        //Premier combat
        //lance combat : gla1[0] vs gla1[0]
        //CA C'EST FAIT


        //Mort gladiateur    
        //si gla1[i] est mort (Combat)
        //gla1[i+1] vs gla2[j]

        //si gla2[i] est mort (Combat)
        //gla1[i] vs gla2[j+1]


        //Fin combat 
        //si gla1[i] == 3
        //joueur2 gagne
        //joueur2 victoire++ et match_joue++
        //joueur1 défaite++ et match_joue++


        //si gla2[i] == 3
        //joueur1 gagne
        //joueur1 victoire++ et match_joue++
        //joueur2 défaite++ et match_joue++




        //Attributs
        private Equipe _eq1;
        private Equipe _eq2;
        private List<Gladiateur> _listeGladiateur1 = new List<Gladiateur>();
        private List<Gladiateur> _listeGladiateur2 = new List<Gladiateur>();

        //Constructeur
        public Round(Equipe eq1, Equipe eq2)
        {
            this._eq1 = eq1;
            this._eq2 = eq2;
            this.recupEquipe();
        }

        //Méthode
        public void recupEquipe()
        {
            //Récupération gladiateurs équipe 1
            foreach (Gladiateur b_gla in _eq1.ListeGladiateur)
            {
                _listeGladiateur1.Add(b_gla);
            }

            //Récupération gladiateurs équipe 2
            foreach (Gladiateur b_gla in _eq2.ListeGladiateur)
            {
                _listeGladiateur2.Add(b_gla);
            }
            
            firstRound(_eq1.ListeGladiateur[0], _eq2.ListeGladiateur[0]);
        }

        public void firstRound(Gladiateur gla1, Gladiateur gla2) //lance le 1e combat : gla1[0] vs gla2[0]
        {
            Combat l_bataille1 = new Combat(gla1, gla2);
            l_bataille1.triArmeAttDef();
            l_bataille1.quiCommence();
            l_bataille1.Attaquer();
			
			if (gla1.Vie == 0) 
			{
				this.recupGlaMort (gla1);
			}

			if (gla2.Vie == 0) 
			{
				this.recupGlaMort (gla2);
			}
        }

        //ICI
        //Y'A
        //UN TRUC
        //CHER MATHOU, JE ME SUIS ARRETE ICI DANS MON CODE
        //Je compte appelé cette méthode depuis la classe combat lorsqu'un gladiateur meurt
        //J'ai pensé cette méthode en 3 étapes : (mais j'ai pas encore réfléchi si c'est faisable)
        //étape1 : je récupère l'attribut gla1 ou gla2 envoyé en paramètre
        //étape2 : je teste si ce gladiateur correspond à un gladiateur de _listeGladiateur1 ou de _listeGladiateur2 (avec un foreach)
        //étape3 : j'appelle la méthode nextRound() avec comme paramètre le gladiateur qui appartient à l'une des deux listes
        public void recupGlaMort(Gladiateur glaMort) //récupère le glaMort et vérifie si il fait partie de eq1 ou eq2 (on l'appelera dans la classe Combat)
        {
            //test si glaMort fait partie de _listeGladiateur1
            foreach (Gladiateur b_gla in _listeGladiateur1)
            {
                if (b_gla == glaMort)
                {
					this.nextRound (b_gla);
                }
            }
        }

        public void nextRound() //quand un gla meurt, lance le combat suivant
        {
			//Mort gladiateur    
			//si gla1[i] est mort (Combat)
			//gla1[i+1] vs gla2[j]

			//si gla2[i] est mort (Combat)
			//gla1[i] vs gla2[j+1]


			//Fin combat 
			//si gla1[i] == 3
			//joueur2 gagne
			//joueur2 victoire++ et match_joue++
			//joueur1 défaite++ et match_joue++


			//si gla2[i] == 3
			//joueur1 gagne
			//joueur1 victoire++ et match_joue++
			//joueur2 défaite++ et match_joue++


        }
    }
}
