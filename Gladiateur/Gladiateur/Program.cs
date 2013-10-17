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
 
			Joueur l_Joueur1 = new Joueur("Biabiany", "Mathis", "Tisma93");
			Joueur l_Joueur2 = new Joueur ("Bui", "Bernard", "BuiToni");

			Bouclier_rectangulaire BouclierRectangulaire = new Bouclier_rectangulaire();
			Casque Casque = new Casque();
			Dague Dague = new Dague ();
			Epee  Epee = new Epee ();
			Filet Filet = new Filet ();
			Lance Lance = new Lance ();
			Petit_bouclier_rond Petit_bouclier_rond = new Petit_bouclier_rond ();
			Trident Trident = new Trident ();

			object[] equipement = new object[] { Epee, Dague, Casque };
			Gladiateur l_Gladiateur1_J1 = new Gladiateur ("Spartacus", equipement);
			Gladiateur l_Gladiateur2_J1 = new Gladiateur ("Crixus", equipement);
			Gladiateur l_Gladiateur3_J1 = new Gladiateur ("Oenemaus", equipement);
			object[] gladiateursJ1 = new object[] { l_Gladiateur1_J1, l_Gladiateur2_J1, l_Gladiateur3_J1 };
			Gladiateur l_Gladiateur1_J2 = new Gladiateur ("Asterix", equipement);
			Gladiateur l_Gladiateur2_J2 = new Gladiateur ("Obelix", equipement);
			Gladiateur l_Gladiateur3_J2 = new Gladiateur ("Panoramix", equipement);
			object[] gladiateursJ2 = new object[] { l_Gladiateur1_J1, l_Gladiateur2_J2, l_Gladiateur3_J2 };

			Equipe l_Equipe1_J1 = new Equipe (l_Joueur1, "Chicago Bulls", "L'équipe des Bulls venu du United Center", gladiateursJ1);
			Equipe l_Equipe1_J2 = new Equipe (l_Joueur2, "Los Angeles Lakers", "L'équipe des Lakers venu du Staples Center", gladiateursJ2);

			Console.WriteLine (l_Joueur1.creerJoueur());
			Console.WriteLine (l_Joueur2.creerJoueur ());

			Console.WriteLine (l_Equipe1_J1.creerEquipe ());
			Console.WriteLine (l_Equipe1_J2.creerEquipe ());
        }
    }
}
