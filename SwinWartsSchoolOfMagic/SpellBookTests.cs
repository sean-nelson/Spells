using NUnit.Framework;
using System;

namespace SwinWartsSchoolOfMagic
{
	/// <summary>
	/// Provides unit tests to test the functionality of the SpellBook class.
	/// </summary>
	[TestFixture ()]
	public class SpellBookTests
	{
		/// <summary>
		/// Tests the add spell method.
		/// </summary>
		[Test ()]
		public void TestAddSpell ()
		{
			SpellBook myBook = new SpellBook ();
			int count = myBook.SpellCount;

			Assert.AreEqual (0, count, "Spell Book should start with 0 spells");

			myBook.AddSpell (new Teleport ("Sean's Teleporter"));
			myBook.AddSpell (new Heal ("Tom's Healer"));
			count = myBook.SpellCount;

			Assert.AreEqual (2, count, "Adding two shapes should increase the count to 2");
		}

		/// <summary>
		/// Tests the remove spell method.
		/// </summary>
		[Test ()]
		public void TestRemoveSpell ()
		{
			SpellBook myBook = new SpellBook ();

			Spell mySpell1 = new Teleport ("Sean's Teleporter");
			Spell mySpell2 = new Heal ("Tom's Healer");
			Spell mySpell3 = new Invisibilty ("Ian's Invisibilty");

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
			Spell testSpell = new Heal ("Test spell");
			myBook.AddSpell (testSpell);

			Assert.AreEqual (testSpell, myBook [0]);

		}
	}
}

