using System;

namespace SwinWartsSchoolOfMagic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			SpellBook mySpellBook = new SpellBook();

			mySpellBook.AddSpell (new Teleport ("Mitch's mighty mover"));
			mySpellBook.AddSpell (new Heal ("Paul's potent poultice"));
			mySpellBook.AddSpell (new Invisibilty ("David's dashing disappearance"));
			mySpellBook.AddSpell (new Teleport ("Stan's stunning shifter"));
			mySpellBook.AddSpell (new Heal ("Lachlan's lavish longevity"));

			CastAll (mySpellBook);

			Console.WriteLine (mySpellBook [2].Name + " - " + mySpellBook [2].Cast ());

			Console.ReadLine ();
		}

		public static void CastAll (SpellBook mySpellBook)
		{
			for (int i = 0; i < mySpellBook.SpellCount; i++) {
				Console.WriteLine (mySpellBook[i].Name + " - " + mySpellBook[i].Cast());
			}
		}
	}
}
