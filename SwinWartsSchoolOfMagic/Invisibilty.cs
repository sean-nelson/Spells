using System;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// A kind of spell that turns the caster invisible.
	/// Can only be cast once.
	/// </summary>
	public class Invisibilty : Spell
	{
		private bool _wasCast;

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinWartsSchoolOfMagic.Invisibilty"/> class.
		/// </summary>
		/// <param name="name">
		/// Used to indicate the spells name.
		/// </param>
		public Invisibilty (string name)
		{
			_wasCast = false;
			Name = name;
		}

		/// <summary>
		/// Tests to see if the spell has been cast.
		/// Casts the instance of Spell and returns a message to the caster.
		/// </summary>
		/// <returns>Returns a string.</returns>
		public override string Cast()
		{
			if (_wasCast == false) 
			{
				_wasCast = true;
				return "Zippp... where am I?";
			} 
			else
			{
				return "Pzzzzzzit";
			}
		}
	}
}

