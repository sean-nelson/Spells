using System;

namespace SwinWartsSchoolOfMagic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Spell[] _spells = new Spell[5];

			_spells [0] = new Spell ("Mitch's mighty mover", SpellKind.Teleport);
			_spells [1] = new Spell ("Paul's potent poultice", SpellKind.Heal);
			_spells [2] = new Spell ("David's dashing disappearance", SpellKind.Invisibilty);
			_spells [3] = new Spell ("Stan's stunning shifter", SpellKind.Teleport);
			_spells [4] = new Spell ("Lachlan's lavish longevity", SpellKind.Heal);

			CastAll (_spells);

			Console.ReadLine ();
		}

		public static void CastAll (Spell[] spells)
		{
			foreach(Spell s in spells) {
				Console.WriteLine (s.Name + " - " + s.Cast());
			}
		}
	}
}
