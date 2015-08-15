using System;

namespace SwinWartsSchoolOfMagic
{
	public class Spell
	{
		private string _name;
		private SpellKind _kind;

		//Properties
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

		public SpellKind Kind
		{
			get 
			{
				return _kind;
			}
		}

		//Constructor
		public Spell (string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		//Methods
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
