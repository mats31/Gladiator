using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gladiateur.Armes;

namespace Gladiateur
{
    class Program
    {
        static void Main(string[] args)
        {
		//Instanciation objet
			//joueur
			Joueur l_j1 = new Joueur("Biabiany", "Mathis", "Tisma93");
			Joueur l_j2 = new Joueur ("Bui", "Bernard", "BuiToni");
            //Joueur l_j3 = new Joueur("Yegin", "Gokan", "Gokan");
            //Joueur l_j4 = new Joueur("Frichet", "Guillaume", "Friscetto");

			//equipe
			Equipe l_bulls = new Equipe ("Chicago Bulls", "L'équipe des Bulls venu du United Center");
			Equipe l_mavericks = new Equipe ("Dallas Mavericks", "L'équipe des Mavericks venu du American Airlines Center");
			Equipe l_lakers = new Equipe ("Los Angeles Lakers", "L'équipe des Lakers venu du Staples Center");

			Equipe l_celtics = new Equipe ("Boston Celtics", "L'équipe des Celtics venu du TD Garden");
			Equipe l_nuggets = new Equipe ("Denver Nuggets", "L'équipe des Nuggets venu du Pepsi Center");
			Equipe l_spurs = new Equipe ("Spurs San Antonio", "L'équipe des Spurs venu du AT&T Center");

            //Equipe l_psg = new Equipe("PSG", "L'équipe du PSG venu de Dubaï");

            //Equipe l_breakingbad = new Equipe("BB", "L'équipe de Breaking Bad venu des States");

			//gladiateur
			Gladiateur l_rose = new Gladiateur ("Rose");
			Gladiateur l_noah = new Gladiateur ("Noah");
			Gladiateur l_deng = new Gladiateur ("Deng");

			Gladiateur l_rondo = new Gladiateur ("Rondo");
			Gladiateur l_pierce = new Gladiateur ("Pierce");
			Gladiateur l_green = new Gladiateur ("Green"); 

			//arme
			Filet l_filet = new Filet ();
			Lance l_lance = new Lance ();
			Epee l_epee = new Epee ();
			Dague l_dague = new Dague ();

			Trident l_trident = new Trident ();

			Bouclier_rectangulaire l_bouclier_rectangle = new Bouclier_rectangulaire ();
			Petit_bouclier_rond l_bouclier_rond = new Petit_bouclier_rond ();
			Casque l_casque = new Casque ();


		//Liste
			//joueur -> equipe
			l_j1.ListeEquipe.Add(l_bulls);
			l_j2.ListeEquipe.Add(l_celtics);
            //l_j3.ListeEquipe.Add(l_psg);
            //l_j4.ListeEquipe.Add(l_breakingbad);

			//equipe -> gladiateur
			l_bulls.ListeGladiateur.Add(l_rose);
			l_bulls.ListeGladiateur.Add(l_noah);
			l_bulls.ListeGladiateur.Add(l_deng);

			l_celtics.ListeGladiateur.Add(l_rondo);
			l_celtics.ListeGladiateur.Add(l_pierce);
			l_celtics.ListeGladiateur.Add(l_green);	


			//gladiateur -> arme
			//Bulls
			l_rose.ListeArme.Add(l_epee);
			l_rose.ListeArme.Add(l_filet);
			l_rose.ListeArme.Add(l_casque);

			l_noah.ListeArme.Add(l_dague);
			l_noah.ListeArme.Add(l_bouclier_rectangle);

			l_deng.ListeArme.Add(l_lance);
			l_deng.ListeArme.Add(l_casque);

			//Celtics
			l_rondo.ListeArme.Add(l_trident);
			l_rondo.ListeArme.Add(l_casque);

			l_pierce.ListeArme.Add(l_filet);
			l_pierce.ListeArme.Add(l_dague);
			l_pierce.ListeArme.Add(l_casque);

			l_green.ListeArme.Add(l_dague);
			l_green.ListeArme.Add(l_dague);
			l_green.ListeArme.Add(l_bouclier_rond);


		//Return - Création
			Message.showMessage(l_j1.connexionJoueurs());
			Message.showMessage(l_j2.connexionJoueurs());
			Message.showMessage ("\n");
			Message.showMessage(l_j1.createEquipe());
			l_bulls.creerGlad ();
			Message.showMessage ("\n");
			l_rose.equipeGlad ();
			Message.showMessage ("\n");
			l_noah.equipeGlad ();
			Message.showMessage ("\n");
			l_deng.equipeGlad ();
			Message.showMessage ("\n");
			Message.showMessage(l_j2.createEquipe());
			l_celtics.creerGlad ();
			Message.showMessage ("\n");
			l_rondo.equipeGlad ();
			Message.showMessage ("\n");
			l_pierce.equipeGlad ();
			Message.showMessage ("\n");
			l_green.equipeGlad ();

		//Return Recap
			Message.showMessage ("\n\n***** ***** ***** ***** ***** *****\nRECAP\n***** ***** ***** ***** ***** *****");
			Message.showMessage ("J1 : "+l_j1.Alias+"\tJ2 : "+l_j2.Alias);
			Message.showMessage ("***** ***** ***** ***** ***** *****");
			Message.showMessage ("Equipes "+l_j1.Alias+" : "+l_j1.getListeEquipe());
			Message.showMessage ("Equipes "+l_j2.Alias+" : "+l_j2.getListeEquipe());
			Message.showMessage ("***** ***** ***** ***** ***** *****");
			Message.showMessage (l_j1.Alias+" - "+ l_j1.ListeEquipe [0].Nom + " : " + l_j1.ListeEquipe [0].getListeJoueur ());
			Message.showMessage (l_j2.Alias+" - "+ l_j2.ListeEquipe [0].Nom + " : " + l_j2.ListeEquipe [0].getListeJoueur ());
			Message.showMessage ("***** ***** ***** ***** ***** *****\n\n");

		//Classement
			Classement classement = new Classement (l_j1,l_j2/*,l_j3,l_j4*/);
			l_bulls.setPcVictoire(50);
			l_celtics.setPcVictoire(60);
            //l_psg.setPcVictoire(40);
            //l_breakingbad.setPcVictoire(30);
			classement.triListeEquipe ();
			Message.showMessage (classement.getClassement());

		//Combat
/*
			Combat l_bataille1 = new Combat (l_rose,l_rondo);
			Message.showMessage(l_bataille1.triArmeAttDef());
			//Message.showMessage(l_bataille1.quiCommence());
			Message.showMessage(l_bataille1.Attaquer());
*/
		//Round
		//	Round l_round1 = new Round(l_bulls, l_celtics);

        //Match
            Match l_match1 = new Match(classement.EquipeClassement);
        }
    }
}
