using System;
using System.Collections.Generic;

namespace SwinWartsSchoolOfMagic
{
	public class SpellBook
	{
		private readonly List<Spell> _spells;

		public SpellBook () 
		{
			_spells = new List<Spell> ();
		}

		public int SpellCount
		{
			get
			{
				return _spells.Count;
			}
		}

		public void AddSpell(Spell s)
		{
			_spells.Add (s);
		}

		public void RemoveSpell(Spell s)
		{
			_spells.Remove (s);
		}

		public Spell this[int i]
		{
			get 
			{
				return _spells [i];
			}

			set 
			{
				_spells [i] = value;
			}
		}
	}

}

