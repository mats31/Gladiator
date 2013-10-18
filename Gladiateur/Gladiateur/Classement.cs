using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiateur
{
	class Classement
	{
		//Attributs
		protected int i=1;
		protected string _classement;
		private List<Equipe> _equipeListe = new List<Equipe> ();
		protected Joueur _j1, _j2;

		public Classement (Joueur j1, Joueur j2)
		{
			this._j1 = j1;
			this._j2 = j2;
		}

		public void recupListeEquipe()
		{
			foreach (var b_equipe in _j1.ListeEquipe) {
				this._equipeListe.Add(b_equipe);
			}
			foreach (var b_equipe in _j2.ListeEquipe) {
				this._equipeListe.Add(b_equipe);
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
			this._classement += "***** *****\n";
			this._classement += "Classement\n";
			this._classement += "***** *****\n";
			foreach (var b_equipe in this._equipeListe) {
				this._classement += this.i;
				this._classement += " ";
				this._classement += b_equipe.Nom;
				this._classement += " ";
				this._classement += b_equipe.pcVictoire;
				this._classement += "\n";
				i++;
			}
			this._classement += "***** *****\n";
			i = 1;
			return _classement;
		}
	}
}

