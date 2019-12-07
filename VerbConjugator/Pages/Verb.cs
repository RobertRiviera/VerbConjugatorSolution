using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Language.Spanish
{
	public enum VerbType
	{
		AR,
		ER,
		IR
	}

	public enum Tense
	{
		Present,
		Preterite,
		Imperfect,
		Conditional,
		Future
	}

	public enum Person
	{
		Yo,
		Tú,
		Él,
		Nosotros,
		Vosotros,
		Ellos
	}

	public enum Mood
	{
		Indicative,
		Imperative,
		Subjunctive,
	}


	public class Verb
	{
		public string Infinitive { get; set; }

		public string Root { get => Infinitive[..^2]; }

		public string Type { get => Infinitive[^2..].ToUpper(); }

		public Verb(string infinitive)
		{
			if (!IsValidInfinitive(infinitive))
				throw new InvalidOperationException("Bad infinitive.");

			Infinitive = infinitive.ToLowerInvariant();
		}
		

		public static bool IsValidInfinitive(string s)
		{
			if (s == null || s.Length < 2)
				return false;

			return s[^2..].ToUpper() switch
			{
				"AR" => true,
				"IR" => true,
				"ER" => true,
				_ => false
			};			
		}


		public string Conjugate(Tense tense, Person person, Mood mood = Mood.Indicative)
		{
			if(tense == Tense.Future)
				return person switch
				{
					Person.Yo => Infinitive + "é",
					Person.Tú => Infinitive + "ás",
					Person.Él => Infinitive + "á",
					Person.Nosotros => Infinitive + "emos",
					Person.Vosotros => Infinitive + "éis",
					Person.Ellos => Infinitive + "án",
					_ => ""
				};
			
			return
			Type switch
			{
				"AR" =>
					tense switch
					{
						Tense.Present => person switch
						{
							Person.Yo => Root + "o",
							Person.Tú => Root + "as",
							Person.Él => Root + "a",
							Person.Nosotros => Root + "amos",
							Person.Vosotros => Root + "áis",
							Person.Ellos => Root + "an",
							_ => ""
						},

						Tense.Preterite => person switch
						{
							Person.Yo => Root + "é",
							Person.Tú => Root + "aste",
							Person.Él => Root + "ó",
							Person.Nosotros => Root + "amos",
							Person.Vosotros => Root + "asteis",
							Person.Ellos => Root + "aron",
							_ => ""
						},

						Tense.Imperfect => person switch
						{
							Person.Yo => Root + "aba",
							Person.Tú => Root + "abas",
							Person.Él => Root + "aba",
							Person.Nosotros => Root + "ábamos",
							Person.Vosotros => Root + "abais",
							Person.Ellos => Root + "aban",
							_ => ""
						},

						Tense.Conditional => person switch          // Sames as IR imperfect!!
						{
							Person.Yo => Infinitive + "ía",
							Person.Tú => Infinitive + "ías",
							Person.Él => Infinitive + "ía",
							Person.Nosotros => Infinitive + "íamos",
							Person.Vosotros => Infinitive + "íais",
							Person.Ellos => Infinitive + "ían",
							_ => ""
						},

						//Tense.Future => person switch
						//{
						//	Person.Yo => Infinitive + "é",
						//	Person.Tú => Infinitive + "ás",
						//	Person.Él => Infinitive + "á",
						//	Person.Nosotros => Infinitive + "emos",
						//	Person.Vosotros => Infinitive + "éis",
						//	Person.Ellos => Infinitive + "án",
						//	_ => ""
						//},
						_ => ""
					},

				"ER" =>
					tense switch
					{
						Tense.Present => person switch
						{
							Person.Yo => Root + "o",
							Person.Tú => Root + "es",
							Person.Él => Root + "e",
							Person.Nosotros => Root + "emos",
							Person.Vosotros => Root + "éis",
							Person.Ellos => Root + "en",
							_ => ""
						},

						Tense.Preterite => person switch
						{
							Person.Yo => Root + "í",
							Person.Tú => Root + "iste",
							Person.Él => Root + "ió",
							Person.Nosotros => Root + "imos",
							Person.Vosotros => Root + "isteis",
							Person.Ellos => Root + "ieron",
							_ => ""
						},

						Tense.Imperfect => person switch
						{
							Person.Yo => Root + "ía",
							Person.Tú => Root + "ías",
							Person.Él => Root + "ía",
							Person.Nosotros => Root + "íamos",
							Person.Vosotros => Root + "íais",
							Person.Ellos => Root + "ían",
							_ => ""
						},

						Tense.Conditional => person switch          // Same as Imperfect above, but with infinitive.
						{
							Person.Yo => Infinitive + "ía",
							Person.Tú => Infinitive + "ías",
							Person.Él => Infinitive + "ía",
							Person.Nosotros => Infinitive + "íamos",
							Person.Vosotros => Infinitive + "íais",
							Person.Ellos => Infinitive + "ían",
							_ => ""
						},

						//Tense.Future => person switch               // Same as AR future
						//{
						//	Person.Yo => Infinitive + "é",
						//	Person.Tú => Infinitive + "ás",
						//	Person.Él => Infinitive + "á",
						//	Person.Nosotros => Infinitive + "emos",
						//	Person.Vosotros => Infinitive + "éis",
						//	Person.Ellos => Infinitive + "án",
						//	_ => ""
						//},
						_ => ""
					},

				"IR" =>
					tense switch
					{
						Tense.Present => person switch
						{
							Person.Yo => Root + "o",
							Person.Tú => Root + "es",
							Person.Él => Root + "e",
							Person.Nosotros => Root + "imos",
							Person.Vosotros => Root + "ís",
							Person.Ellos => Root + "en",
							_ => ""
						},

						Tense.Preterite => person switch
						{
							Person.Yo => Root + "í",
							Person.Tú => Root + "iste",
							Person.Él => Root + "ió",
							Person.Nosotros => Root + "imos",
							Person.Vosotros => Root + "isteis",
							Person.Ellos => Root + "ieron",
							_ => ""
						},

						Tense.Imperfect => person switch
						{
							Person.Yo => Root + "ía",
							Person.Tú => Root + "ías",
							Person.Él => Root + "ía",
							Person.Nosotros => Root + "íamos",
							Person.Vosotros => Root + "íais",
							Person.Ellos => Root + "ían",
							_ => ""
						},

						Tense.Conditional => person switch          // Same as above but with infinitive
						{
							Person.Yo => Infinitive + "ía",
							Person.Tú => Infinitive + "ías",
							Person.Él => Infinitive + "ía",
							Person.Nosotros => Infinitive + "íamos",
							Person.Vosotros => Infinitive + "íais",
							Person.Ellos => Infinitive + "ían",
							_ => ""
						},

						//Tense.Future => person switch               // Same as AR and ER future
						//{
						//	Person.Yo => Infinitive + "é",
						//	Person.Tú => Infinitive + "ás",
						//	Person.Él => Infinitive + "á",
						//	Person.Nosotros => Infinitive + "emos",
						//	Person.Vosotros => Infinitive + "éis",
						//	Person.Ellos => Infinitive + "án",
						//	_ => ""
						//},
						_ => ""
					},
				_ => ""
			};
		}
	}
}
