using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Round
    {
		private List<Gladiateur> _gladiateurs1  = new List<Gladiateur> ();
		private List<Gladiateur> _gladiateurs2  = new List<Gladiateur> ();

        public Round(Equipe equipe1, Equipe equipe2)
        {
			this._gladiateurs1 = equipe1.ListeGladiateur;
			this._gladiateurs2 = equipe2.ListeGladiateur;

			this.LauchRound ();
        }

		public void LauchRound() 
		{
			Console.WriteLine (_gladiateurs1 [0].Nom);
			Console.WriteLine (_gladiateurs2 [0].Nom);
			Combat l_bataille1 = new Combat (_gladiateurs1[0],_gladiateurs2[0]);
			Message.showMessage(l_bataille1.triArmeAttDef());
			Message.showMessage(l_bataille1.quiCommence());
			Message.showMessage(l_bataille1.Attaquer());
		}
	}
}
