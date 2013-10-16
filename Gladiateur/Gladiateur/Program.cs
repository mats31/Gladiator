using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Program
    {
        static void Main(string[] args)
        {
			Joueur l_Joueur1 = new Joueur("Biabiany", "Mathis", "Tisma93");
			Joueur l_Joueur2 = new Joueur ("Bui", "Bernard", "BuiToni");

			Console.WriteLine (l_Joueur1);
        }
    }
}
