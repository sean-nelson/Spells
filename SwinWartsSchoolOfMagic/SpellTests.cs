using NUnit.Framework;
using System;

namespace SwinWartsSchoolOfMagic
{
	[TestFixture ()]
	public class SpellTests
	{
		[Test ()]
		public void TestTeleportCast ()
		{
			Spell s = new Spell ("Teleport", SpellKind.Teleport);

			StringAssert.IsMatch ("Poof... you appear somewhere else", s.Cast ());
		}

		[Test ()]
		public void TestHealCast ()
		{
			Spell s = new Spell ("Heal", SpellKind.Heal);

			StringAssert.IsMatch ("Ahhh... you feel better", s.Cast ());
		}

		[Test ()]
		public void TestInvisibilityCast ()
		{
			Spell s = new Spell ("Invisibility", SpellKind.Invisibilty);

			StringAssert.IsMatch ("Zippp... where am I?", s.Cast ());
		}

		[Test ()]
		public void TestSpellNameChange ()
		{
			Spell s = new Spell ("Mitch's mighty mover", SpellKind.Teleport);

			StringAssert.IsMatch ("Mitch's mighty mover", s.Name);

			s.Name = "Pete's powerful puller";

			StringAssert.IsMatch ("Pete's powerful puller", s.Name);
		}
	}
}

