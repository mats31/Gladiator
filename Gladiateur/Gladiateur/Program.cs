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

			//equipe
			Equipe l_bulls = new Equipe ("Chicago Bulls", "L'équipe des Bulls venu du United Center");
			Equipe l_mavericks = new Equipe ("Dallas Mavericks", "L'équipe des Mavericks venu du American Airlines Center");
			Equipe l_lakers = new Equipe ("Los Angeles Lakers", "L'équipe des Lakers venu du Staples Center");

			Equipe l_celtics = new Equipe ("Boston Celtics", "L'équipe des Celtics venu du TD Garden");
			Equipe l_nuggets = new Equipe ("Denver Nuggets", "L'équipe des Nuggets venu du Pepsi Center");
			Equipe l_spurs = new Equipe ("Spurs San Antonio", "L'équipe des Spurs venu du AT&T Center");

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
			l_j1.setEquipe(l_bulls);
			l_j2.setEquipe(l_celtics);


			//equipe -> gladiateur
			l_bulls.setGladiateur(l_rose);
			l_bulls.setGladiateur(l_noah);
			l_bulls.setGladiateur(l_deng);

			l_celtics.setGladiateur(l_rondo);
			l_celtics.setGladiateur(l_pierce);
			l_celtics.setGladiateur(l_green);	


			//gladiateur -> arme
			//Bulls
			l_rose.setArme(l_epee);
			l_rose.setArme(l_filet);
			l_rose.setArme(l_casque);

			l_noah.setArme(l_dague);
			l_noah.setArme(l_bouclier_rectangle);

			l_deng.setArme(l_lance);
			l_deng.setArme(l_casque);

			//Celtics
			l_rondo.setArme(l_trident);
			l_rondo.setArme(l_casque);

			l_pierce.setArme(l_filet);
			l_pierce.setArme(l_dague);
			l_pierce.setArme(l_casque);

			l_green.setArme(l_dague);
			l_green.setArme(l_dague);
			l_green.setArme(l_bouclier_rond);


		//Return - Création
/*			Console.WriteLine(l_j1.connexionJoueurs());
			Console.WriteLine(l_j2.connexionJoueurs());
			Console.WriteLine ("\n");
			Console.WriteLine(l_j1.createEquipe());
			l_bulls.creerGlad ();
			Console.WriteLine ("\n");
			l_rose.equipeGlad ();
			Console.WriteLine ("\n");
			l_noah.equipeGlad ();
			Console.WriteLine ("\n");
			l_deng.equipeGlad ();
			Console.WriteLine ("\n");
			Console.WriteLine(l_j2.createEquipe());
			l_celtics.creerGlad ();
			Console.WriteLine ("\n");
			l_rondo.equipeGlad ();
			Console.WriteLine ("\n");
			l_pierce.equipeGlad ();
			Console.WriteLine ("\n");
			l_green.equipeGlad ();
*/
		//Recap
			Console.WriteLine ("\n\n***** ***** ***** ***** ***** *****\nRECAP\n***** ***** ***** ***** ***** *****");
			Console.WriteLine ("J1 : "+l_j1.Alias+"\tJ2 : "+l_j2.Alias);
			Console.WriteLine ("***** ***** ***** ***** ***** *****");
			Console.WriteLine ("Equipes "+l_j1.Alias+" : "+l_j1.getListeEquipe());
			Console.WriteLine ("Equipes "+l_j2.Alias+" : "+l_j2.getListeEquipe());
			Console.WriteLine ("***** ***** ***** ***** ***** *****");
			Console.WriteLine (l_j1.Alias+" - "+ l_j1.getEquipe(0).Nom + " : " + l_j1.getEquipe(0).getListeJoueur ());
			Console.WriteLine (l_j2.Alias+" - "+ l_j2.getEquipe(0).Nom + " : " + l_j2.getEquipe(0).getListeJoueur ());
			Console.WriteLine ("***** ***** ***** ***** ***** *****\n\n");
		
		//Choix
			l_j1.choixEquipe (l_bulls);
			l_j2.choixEquipe (l_celtics);


		//Classement
			Classement classement = new Classement (l_j1,l_j2);


			l_bulls.setPcVictoire(50);
			l_celtics.setPcVictoire(60);
			classement.recupEquipeFight ();
			classement.triListeEquipe ();
			Console.WriteLine (classement.getClassement());

		

		//Combat
			Combat l_bataille1 = new Combat (l_rose,l_rondo);
			Console.WriteLine(l_bataille1.triArmeAttDef());
			Console.WriteLine(l_bataille1.quiCommence());
			Console.WriteLine(l_bataille1.Attaquer());


        }
    }
}
