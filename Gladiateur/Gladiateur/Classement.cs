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
		//private List<Equipe> _equipeClassement = new List<Equipe> ();
        private List<Equipe> _equipeClassement = new List<Equipe>();
        public List<Equipe> EquipeClassement
        {
            get
            {
                return _equipeClassement;
            }
            private set
            {
                _equipeClassement = value;
            }
        }


		//Constructeur
		public Classement ()
		{
		}

		public Classement (params Joueur[] joueur)
		{
            // Vérification du nombre minimum de joueur
            if (joueur.Length > 1) {
                foreach (Joueur j in joueur) {
                    // Vérification du nombre d'équipes
                    if (j.ListeEquipe.Count > 0) {
                        EquipeClassement.Add(j.ListeEquipe[0]);
                    } else {
                        throw new Exception("Le joueur " + j.Alias + " n'a aucune d'équipe");
                    }
                }
            } else {
                throw new Exception("Minimum 2 joueurs");
            }
        }

		//Méthode
/*		public void recupEquipeFight()
		{
			foreach (var item in _equipeListe) {
	
			}

			_equipeListe.Add(_j1.EquipeFight);
			_equipeListe.Add(_j2.EquipeFight);
		}
*/
		public void triListeEquipe()
		{
            _equipeClassement = (from b_equipe in _equipeClassement
			              			orderby b_equipe.pcVictoire descending
			               			select b_equipe).ToList ();
		}

		public string getClassement()
		{
			_classement += "\n\n***** ***** *****\n";
			_classement += "CLASSEMENT\n";
			_classement += "***** ***** *****\n";
            foreach (var b_equipe in _equipeClassement)
            {
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

