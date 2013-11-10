using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Match
    {
        //Attributs
        List<Equipe> _equipeClassement = new List<Equipe> ();

        //Constructeur
		public Match(List<Equipe> equipeClassement)
		{
			this._equipeClassement = equipeClassement;
            this.quiContreQui();
		}

        //Méthode
        public void quiContreQui()
        {
            for(int i=0; i<_equipeClassement.Count; i+=2)
            {
                //Test console fonctionne (à commenter quand la classe Round est bonne)
                //Message.showMessage(_equipeClassement[i].Nom+" contre "+_equipeClassement[i+1].Nom);
                
                //Vrai méthode (à décommenter quand la classe Round est bonne)
                    Round l_round1 = new Round(_equipeClassement[i], _equipeClassement[i + 1]);
            }
        }

        
    }
}
