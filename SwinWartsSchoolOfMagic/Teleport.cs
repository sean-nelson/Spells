using System;

namespace SwinWartsSchoolOfMagic
{
	public class Teleport : Spell
	{
		private static Random _random = new Random();

		public Teleport (string name)
		{
			Name = name;
		}

		public override string Cast()
		{
			if (_random.NextDouble() < 0.5) 
			{
				return "Poof... you appear somewhere else";
			} 
			else 
			{
				return "Ahhh... I'm too tired to move";
			}
		}
	}
}

