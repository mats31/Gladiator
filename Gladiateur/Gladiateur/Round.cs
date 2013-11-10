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
		private int _index1 = 0;
		private int _index2 = 0;
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
            
            launchRound(_eq1.ListeGladiateur[0], _eq2.ListeGladiateur[0]);
        }

        public void launchRound(Gladiateur gla1, Gladiateur gla2) //lance le 1e combat : gla1[0] vs gla2[0]
        {
            Combat l_bataille1 = new Combat(gla1, gla2);
            l_bataille1.triArmeAttDef();
            l_bataille1.quiCommence();
            l_bataille1.Attaquer();

			//Console.WriteLine (gla1.Vie);
			//Console.WriteLine(gla2.Vie);

			if (gla1.Vie == 0 && gla2.Vie == 1) 
			{
				this.recupGlaMort (gla1);
			}

			if (gla2.Vie == 0 && gla1.Vie == 1) 
			{
				this.recupGlaMort (gla2);
			}

			if (gla2.Vie == 0 && gla1.Vie == 0) 
			{
				this.recupGlasMorts (gla1, gla2);
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
				//Console.WriteLine (b_gla);
				//Console.WriteLine (glaMort);
                if (b_gla == glaMort)
                {
					this.nextRound (b_gla);
                }
            }

			foreach (Gladiateur b_gla in _listeGladiateur2)
			{
				if (b_gla == glaMort)
				{
					this.nextRound (b_gla);
				}
			}
        }

		public void recupGlasMorts(Gladiateur glaMort1, Gladiateur glaMort2) //récupère le glaMort et vérifie si il fait partie de eq1 ou eq2 (on l'appelera dans la classe Combat)
		{

			this._index1++;
			this._index2++;

			if (this._index1 == 3 && this._index2 < 3) 
			{
				Message.showMessage("L'équipe "+_eq2.Nom+" a vaincu l'équipe "+_eq1.Nom+" !");
			}

			if (this._index2 == 3 && this._index1 < 3) 
			{
				Message.showMessage("L'équipe "+_eq1.Nom+" a vaincu l'équipe "+_eq2.Nom+" !");
			}

			if (this._index1 == 3 && this._index2 == 3) 
			{
				Message.showMessage("Les équipes "+_eq1.Nom+" et "+_eq2.Nom+" n'ont plus de gladiateurs valides. Le duel se termine sur un match nul !");
			}

			if (this._index1 < 3 && this._index2 < 3) 
			{
				this.launchRound(_listeGladiateur1[this._index1], _listeGladiateur2[this._index2]);
			}

		}

        public void nextRound(Gladiateur glaMort) //quand un gla meurt, lance le combat suivant
        {
			foreach (Gladiateur b_gla in _listeGladiateur1)
			{
				Console.WriteLine (b_gla.Nom);
				Console.WriteLine (glaMort.Nom);
				if (b_gla == glaMort)
				{
					int index = _listeGladiateur1.IndexOf(b_gla);
					Console.WriteLine ("L'index :");
					Console.WriteLine (index);
					this.launchRound(_listeGladiateur1[index+1], _listeGladiateur2[this._index2]);
					this._index1 = index + 1;
				}
			}

			foreach (Gladiateur b_gla in _listeGladiateur2)
			{
				Console.WriteLine (b_gla.Nom);
				Console.WriteLine (glaMort.Nom);
				if (b_gla == glaMort)
				{
					int index = _listeGladiateur2.IndexOf(b_gla);
					this.launchRound(_listeGladiateur1[this._index1], _listeGladiateur2[index+1]);
					this._index2 = index + 1;
				}
			}

			if (this._index1 == 3 && this._index2 < 3) 
			{
				Message.showMessage("L'équipe "+_eq2.Nom+" a vaincu l'équipe "+_eq1.Nom+" !");
			}

			if (this._index2 == 3 && this._index1 < 3) 
			{
				Message.showMessage("L'équipe "+_eq1.Nom+" a vaincu l'équipe "+_eq2.Nom+" !");
			}

			if (this._index1 == 3 && this._index2 == 3) 
			{
				Message.showMessage("Les équipes "+_eq1.Nom+" et "+_eq2.Nom+" n'ont plus de gladiateurs valides. Le duel se termine sur un match nul !");
			}
        }
    }
}
