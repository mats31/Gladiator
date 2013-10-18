using System;

namespace Gladiateur.Armes
{
	public abstract class Arme
	{
		//Constructeur
		public Arme ()
		{
		}

		public Arme (string _nom, int _points, bool _attaque, bool _defense, int _initiative, float _pc_touche)
		{
			this.Nom = _nom;
			this.Points = _points;
			this.Attaque = _attaque;
			this.Defense = _defense;
			this.Initiative = _initiative;
			this.Pc_touche = _pc_touche;
		}

		//Getters-Setters
		private string _nom;
		public string Nom {
			get { return this._nom; }
			protected set { this._nom = value; }
		}
		private int _points;
		public int Points {
			get { return this._points; }
			protected set { this._points = value; }
		}
		private bool _attaque;
		public bool Attaque {
			get { return this._attaque; }
			protected set { this._attaque = value; }
		}
		private bool _defense;
		public bool Defense {
			get { return this._defense; }
			protected set { this._defense = value; }
		}
		private int _initiative;
		public int Initiative {
			get { return this._initiative; }
			protected set { this._initiative = value; }
		}
		private float _pc_touche;
		public float Pc_touche {
			get { return this._pc_touche; }
			set { this._pc_touche = value; }
		}
	
		public abstract bool Attaquer ();
		public abstract bool Defendre ();

	}
}

