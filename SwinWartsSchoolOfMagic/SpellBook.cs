using System;
using System.Collections.Generic;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// SpellBooks can be created to store zero or more spells. 
	/// Spells can be added or removed at any time by a wizard and
	/// the individual spells can be accessed by fetching the spell 
	/// at a given index in the SpellBook.
	/// </summary>
	public class SpellBook
	{
		private readonly List<Spell> _spells;

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinWartsSchoolOfMagic.SpellBook"/> class.
		/// </summary>
		public SpellBook () 
		{
			_spells = new List<Spell> ();
		}

		/// <summary>
		/// Gets the spell count.
		/// </summary>
		/// <value>The number of spells contained within the spellbook.</value>
		public int SpellCount
		{
			get
			{
				return _spells.Count;
			}
		}

		/// <summary>
		/// Adds a spell into the spellbook.
		/// </summary>
		/// <param name="spell">The spell passed to the method.</param>
		public void AddSpell(Spell spell)
		{
			_spells.Add (spell);
		}

		/// <summary>
		/// Removes a spell from the spellbook.
		/// </summary>
		/// <param name="spell">The spell passed to the method.</param>
		public void RemoveSpell(Spell spell)
		{
			_spells.Remove (spell);
		}

		/// <summary>
		/// Gets the <see cref="SwinWartsSchoolOfMagic.SpellBook"/> with the specified i.
		/// </summary>
		/// <param name="i">The index indicating the location for 
		/// each stoed spell within the spellbook.</param>
		public Spell this[int i]
		{
			get 
			{
				return _spells [i];
			}
		}
	}

}

