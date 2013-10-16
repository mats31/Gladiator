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
			
			Equipe l_Equipe1_J1 = new Equipe (l_Joueur1, "Chicago Bulls", "L'équipe des Bulls venu du United Center");
			Equipe l_Equipe1_J2 = new Equipe (l_Joueur2, "Los Angeles Lakers", "L'équipe des Lakers venu du Staples Center"); 

			Console.WriteLine (l_Joueur1.creerJoueur());
			Console.WriteLine (l_Joueur2.creerJoueur ());

			Console.WriteLine (l_Equipe1_J1.creerEquipe ());
			Console.WriteLine (l_Equipe1_J2.creerEquipe ());
        }
    }
}
