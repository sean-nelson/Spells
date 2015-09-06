using NUnit.Framework;
using System;

namespace SwinWartsSchoolOfMagic
{
	[TestFixture ()]
	public class SpellBookTests
	{
		[Test ()]
		public void TestAddSpell ()
		{
			SpellBook myBook = new SpellBook ();
			int count = myBook.SpellCount;

			Assert.AreEqual (0, count, "Spell Book should start with 0 spells");

			myBook.AddSpell (new Spell ("Sean's Teleporter", SpellKind.Teleport));
			myBook.AddSpell (new Spell ("Tom's Healer", SpellKind.Heal));
			count = myBook.SpellCount;

			Assert.AreEqual (2, count, "Adding two shapes should increase the count to 2");
		}

		[Test ()]
		public void TestRemoveSpell ()
		{
			SpellBook myBook = new SpellBook ();

			Spell mySpell1 = new Spell ("Sean's Teleporter", SpellKind.Teleport);
			Spell mySpell2 = new Spell ("Tom's Healer", SpellKind.Heal);
			Spell mySpell3 = new Spell ("Ian's Invisibilty", SpellKind.Invisibilty);

			myBook.AddSpell (mySpell1);
			myBook.AddSpell (mySpell2);
			myBook.AddSpell (mySpell3);

			Assert.AreEqual (3, myBook.SpellCount);

			myBook.RemoveSpell (mySpell2);

			Assert.AreEqual (2, myBook.SpellCount);
		}

		/// <summary>
		/// Tests the indexer used to access spells in the spell book.
		/// Creates a new SpellBook and a new Spell and adds the spell to the SpellBook.
		/// Then tests whether the local Spell and the Spell contained in the Spellbook
		/// are equal using the indexer.
		/// </summary>
		[Test ()]
		public void TestFetchSpell ()
		{
			
			SpellBook myBook = new SpellBook ();
			Spell testSpell = new Spell ("Test spell", SpellKind.Heal);
			myBook.AddSpell (testSpell);

			Assert.AreEqual (testSpell, myBook [0]);

		}
	}
}

