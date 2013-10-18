using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiateur
{
	class Classement
	{
		//Attributs
		private int i=1;
		private string _classement;
		private List<Equipe> _equipeListe = new List<Equipe> ();
		private Joueur _j1, _j2;

		//Constructeur
		public Classement ()
		{
		}

		public Classement (Joueur j1, Joueur j2)
		{
			_j1 = j1;
			_j2 = j2;
		}

		//Méthode
		public virtual void recupListeEquipe()
		{
			foreach (var b_equipe in _j1.ListeEquipe) {
				_equipeListe.Add(b_equipe);
			}
			foreach (var b_equipe in _j2.ListeEquipe) {
				_equipeListe.Add(b_equipe);
			}
		}

		public void triListeEquipe()
		{
			_equipeListe = (from b_equipe in _equipeListe
			              			orderby b_equipe.pcVictoire descending
			               			select b_equipe).ToList ();
		}

		public string getClassement()
		{
			_classement += "***** ***** *****\n";
			_classement += "CLASSEMENT\n";
			_classement += "***** ***** *****\n";
			foreach (var b_equipe in _equipeListe) {
				_classement += i;
				_classement += " ";
				_classement += b_equipe.Nom;
				_classement += " ";
				_classement += b_equipe.pcVictoire;
				_classement += "\n";
				i++;
			}
			_classement += "***** ***** *****\n";
			i = 1;
			return _classement;
		}

	}
}

