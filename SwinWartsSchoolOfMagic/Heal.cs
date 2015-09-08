using System;

namespace SwinWartsSchoolOfMagic
{
	public class Heal : Spell
	{
		public Heal (string name)
		{
			Name = name;
		}

		public override string Cast()
		{
			return "Ahhh... you feel better";
		}
	}
}

