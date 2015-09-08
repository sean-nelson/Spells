using System;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// Spells can be cast in order to munipulate the
	/// caster's surroundings or themselves. 
	/// There are a few different types of spells, each
	/// with their own effects.
	/// </summary>
	public abstract class Spell
	{
		private string _name;

		/// <summary>
		/// The Name property represents the spell's name.
		/// </summary>
		/// <value>The Name property gets/sets the value of the string field, _name.</value>
		public string Name
		{
			get 
			{
				return _name;
			} 
			set 
			{
				_name = value;
			}
		}

		public Spell () : this ("Teleport Spell") {}

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinWartsSchoolOfMagic.Spell"/> class.
		/// </summary>
		/// <param name="name">Used to indicate the spell's Name.</param>
		/// <param name="kind">Used to indicate the spell's Kind.</param>
		public Spell (string name)
		{
			_name = name;
		}

		/// <summary>
		/// Casts the instance of Spell and returns a message to the caster. 
		/// </summary>
		/// <returns>
		/// Returns a string.
		/// </returns>
		public abstract string Cast();
	}
}
