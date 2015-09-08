using System;

namespace SwinWartsSchoolOfMagic
{
	public class Invisibilty : Spell
	{
		private bool _wasCast;

		public Invisibilty (string name)
		{
			_wasCast = false;
			Name = name;
		}

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

