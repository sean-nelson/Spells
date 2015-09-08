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
			Spell s = new Teleport ("Teleport");
			string result = s.Cast ();
			Assert.IsTrue (result == "Poof... you appear somewhere else" || result == "Ahhh... I'm too tired to move");
		}

		[Test ()]
		public void TestHealCast ()
		{
			Spell s = new Heal ("Heal");

			StringAssert.IsMatch ("Ahhh... you feel better", s.Cast ());
		}

		[Test ()]
		public void TestInvisibilityCast ()
		{
			Spell s = new Invisibilty ("Invisibility");

			StringAssert.IsMatch ("Zippp... where am I?", s.Cast ());
		}

		[Test ()]
		public void TestSpellNameChange ()
		{
			Spell s = new Teleport ("Mitch's mighty mover");

			StringAssert.IsMatch ("Mitch's mighty mover", s.Name);

			s.Name = "Pete's powerful puller";

			StringAssert.IsMatch ("Pete's powerful puller", s.Name);
		}
	}
}

