using NUnit.Framework;
using System;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// PRovides unit tests in order to test the functionality 
	/// of the Spell class and its child classes.
	/// </summary>
	[TestFixture ()]
	public class SpellTests
	{
		/// <summary>
		/// Tests the teleport cast.
		/// </summary>
		[Test ()]
		public void TestTeleportCast ()
		{
			Spell s = new Teleport ("Teleport");
			string result = s.Cast ();
			Assert.IsTrue (result == "Poof... you appear somewhere else" || result == "Ahhh... I'm too tired to move");
		}

		/// <summary>
		/// Tests the heal cast.
		/// </summary>
		[Test ()]
		public void TestHealCast ()
		{
			Spell s = new Heal ("Heal");

			StringAssert.IsMatch ("Ahhh... you feel better", s.Cast ());
		}

		/// <summary>
		/// Tests the invisibility cast.
		/// </summary>
		[Test ()]
		public void TestInvisibilityCast ()
		{
			Spell s = new Invisibilty ("Invisibility");

			StringAssert.IsMatch ("Zippp... where am I?", s.Cast ());
		}

		/// <summary>
		/// Tests changing the name of spell.
		/// </summary>
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

