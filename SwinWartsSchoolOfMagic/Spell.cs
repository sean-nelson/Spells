using System;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// Spells can be cast in order to munipulate the
	/// caster's surroundings or themselves. 
	/// There are a few different types of spells, each
	/// with their own effects.
	/// </summary>
	public class Spell
	{
		private string _name;
		private SpellKind _kind;

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

		/// <summary>
		/// The Kind property represents the spell's kind.
		/// One of three kinds: Teleport, Heal or Invisibilty.
		/// </summary>
		/// <value>The Kind property gets the value of the SpellKind field, _kind.</value>
		public SpellKind Kind
		{
			get 
			{
				return _kind;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinWartsSchoolOfMagic.Spell"/> class.
		/// </summary>
		/// <param name="name">Used to indicate the spell's Name.</param>
		/// <param name="kind">Used to indicate the spell's Kind.</param>
		public Spell (string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		/// <summary>
		/// Casts the instance of Spell and returns a message to the caster. 
		/// </summary>
		/// <returns>
		/// Returns a string.
		/// </returns>
		public string Cast()
		{

			switch (_kind) 
			{
			case SpellKind.Teleport:
				return "Poof... you appear somewhere else";
			case SpellKind.Heal:
				return "Ahhh... you feel better";
			case SpellKind.Invisibilty:
				return "Zippp... where am I?";
			default: return "You are a great wizard, even I don't know what that spell is!";
			}
		}
	}
}
