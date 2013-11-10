using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiateur
{
    class Round
    {
		private Equipe _equipe1;
		private Equipe _equipe2;
		private int index1 = 0;
		private int index2 = 0;
		private List<Gladiateur> _gladiateurs1  = new List<Gladiateur> ();
		private List<Gladiateur> _gladiateurs2  = new List<Gladiateur> ();

        public Round(Equipe equipe1, Equipe equipe2)
        {
			this._equipe1 = equipe1;
			this._equipe2 = equipe2;

			this._gladiateurs1 = equipe1.ListeGladiateur;
			this._gladiateurs2 = equipe2.ListeGladiateur;

			this.LauchRound (_gladiateurs1[0], _gladiateurs2[0]);
        }

		public void LauchRound(Gladiateur gladiateur1, Gladiateur gladiateur2) 
		{
			Console.WriteLine (gladiateur1.Vie);
			Console.WriteLine (gladiateur2.Vie);
			Combat l_bataille1 = new Combat (gladiateur1, gladiateur2);
			Message.showMessage(l_bataille1.triArmeAttDef());
			//Message.showMessage(l_bataille1.quiCommence());
			Message.showMessage(l_bataille1.Attaquer());

			this.nextRound ();
		}

		public void nextRound()
		{
			foreach (Gladiateur b_glad in this._gladiateurs1) {
				if (b_glad.Vie == 1) 
				{
					Console.WriteLine ("Nom de bglad :" +b_glad.Nom+ ". Vie de bglad :"+b_glad.Vie+" in team 1.");
					this.index1 = _gladiateurs1.IndexOf (b_glad);
					Console.WriteLine ("Valeur d'index1 :" +index1);
					break;
				}
				else 
				{
					this.index1 = 3;
				}
			}

			foreach (Gladiateur b_glad in this._gladiateurs2) {
				if (b_glad.Vie == 1) {
					Console.WriteLine ("Nom de bglad :" + b_glad.Nom + ". Vie de bglad :" + b_glad.Vie + " in team 2.");
					this.index2 = _gladiateurs2.IndexOf (b_glad);
					Console.WriteLine ("Valeur d'index2 :" + index2);
					break;
				} 
				else 
				{
					this.index2 = 3;
				}
			}

			if (this.index1 < 3 && this.index2 < 3) 
			{
				Console.WriteLine (this.index1);
				Console.WriteLine (this.index2);
				this.LauchRound (this._gladiateurs1 [this.index1], this._gladiateurs2 [this.index2]);
			}

			if (this.index1 == 3 && this.index2 < 3) 
			{
				Message.showMessage ("L'équipe " + _equipe1.Nom + " a perdu !");
			}

			if (this.index1 < 3 && this.index2 == 3) 
			{
				Message.showMessage ("L'équipe " + _equipe2.Nom + " a perdu !");
			}

			if (this.index1 == 3 && this.index2 == 3) 
			{
				Message.showMessage ("C'est un match nul !");
			}
		}
	}
}
