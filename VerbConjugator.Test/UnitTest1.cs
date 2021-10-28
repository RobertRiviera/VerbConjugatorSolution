using Language.Spanish;
using Xunit;

namespace VerbConjugator.Test
{
	public class UnitTest1
	{
		[Fact]
		public void TestPresentTense_AR()
		{
			Verb verb = new Verb("cantar");
			Tense tense = Tense.Present;

			Assert.Equal("canto", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("cantas", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("canta", verb.Conjugate(tense, Person.Él));
			Assert.Equal("cantamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("cantáis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("cantan", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPresentTense_ER()
		{
			Verb verb = new Verb("aprender");
			Tense tense = Tense.Present;

			Assert.Equal("xaprendo", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("aprendes", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("aprende", verb.Conjugate(tense, Person.Él));
			Assert.Equal("aprendemos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("aprendéis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("aprenden", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPresentTense_IR()
		{
			Verb verb = new Verb("abrir");
			Tense tense = Tense.Present;

			Assert.Equal("abro", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("abres", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("abre", verb.Conjugate(tense, Person.Él));
			Assert.Equal("abrimos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("abrís", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("abren", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_AR()
		{
			Verb verb = new Verb("hablar");
			Tense tense = Tense.Preterite;

			Assert.Equal("hablé", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("hablaste", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("habló", verb.Conjugate(tense, Person.Él));
			Assert.Equal("hablamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("hablasteis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("hablaron", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_ER()
		{
			Verb verb = new Verb("aprender");
			Tense tense = Tense.Preterite;

			Assert.Equal("aprendí", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("aprendiste", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("aprendió", verb.Conjugate(tense, Person.Él));
			Assert.Equal("aprendimos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("aprendisteis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("aprendieron", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_IR()
		{
			Verb verb = new Verb("sufrir");
			Tense tense = Tense.Preterite;

			Assert.Equal("sufrí", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("sufriste", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("sufrió", verb.Conjugate(tense, Person.Él));
			Assert.Equal("sufrimos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("sufristeis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("sufrieron", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestImperfectTense_AR()
		{
			Verb verb = new Verb("bailar");
			Tense tense = Tense.Imperfect;

			Assert.Equal("bailaba", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("bailabas", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("bailaba", verb.Conjugate(tense, Person.Él));
			Assert.Equal("bailábamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("bailabais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("bailaban", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestImperfectTense_ER()
		{
			Verb verb = new Verb("vender");
			Tense tense = Tense.Imperfect;

			Assert.Equal("vendía", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("vendías", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("vendía", verb.Conjugate(tense, Person.Él));
			Assert.Equal("vendíamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("vendíais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("vendían", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestImperfectTense_IR()
		{
			Verb verb = new Verb("vivir");
			Tense tense = Tense.Imperfect;

			Assert.Equal("vivía", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("vivías", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("vivía", verb.Conjugate(tense, Person.Él));
			Assert.Equal("vivíamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("vivíais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("vivían", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_AR()
		{
			Verb verb = new Verb("cantar");
			Tense tense = Tense.Conditional;

			Assert.Equal("cantaría", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("cantarías", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("cantaría", verb.Conjugate(tense, Person.Él));
			Assert.Equal("cantaríamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("cantaríais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("cantarían", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_ER()
		{
			Verb verb = new Verb("conocer");
			Tense tense = Tense.Conditional;

			Assert.Equal("conocería", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("conocerías", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("conocería", verb.Conjugate(tense, Person.Él));
			Assert.Equal("conoceríamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("conoceríais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("conocerían", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_IR()
		{
			Verb verb = new Verb("vivir");
			Tense tense = Tense.Conditional;

			Assert.Equal("viviría", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("vivirías", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("viviría", verb.Conjugate(tense, Person.Él));
			Assert.Equal("viviríamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("viviríais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("vivirían", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_AR()
		{
			Verb verb = new Verb("tratar");
			Tense tense = Tense.Future;

			Assert.Equal("trataré", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("tratarás", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("tratará", verb.Conjugate(tense, Person.Él));
			Assert.Equal("trataremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("trataréis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("tratarán", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_ER()
		{
			Verb verb = new Verb("correr");
			Tense tense = Tense.Future;

			Assert.Equal("correré", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("correrás", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("correrá", verb.Conjugate(tense, Person.Él));
			Assert.Equal("correremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("correréis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("correrán", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_IR()
		{
			Verb verb = new Verb("sequir");
			Tense tense = Tense.Future;

			Assert.Equal("sequiré", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("sequirás", verb.Conjugate(tense, Person.Tú));
			Assert.Equal("sequirá", verb.Conjugate(tense, Person.Él));
			Assert.Equal("sequiremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("sequiréis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("sequirán", verb.Conjugate(tense, Person.Ellos));
		}


		[Theory]
		[InlineData("hablar")]
		[InlineData("cantar")]
		[InlineData("llorar")]
		public void IsVerbType_AR(string v)
		{
			Verb verb = new Verb(v);

			var result = verb.Type == "AR";

			Assert.True(result);
		}


		[Theory]
		[InlineData("aprender")]
		public void IsVerbType_ER(string v)
		{
			Verb verb = new Verb(v);

			var result = verb.Type == "ER";

			Assert.True(result);
		}


		[Theory]
		[InlineData("hablar")]
		[InlineData("cantar")]
		[InlineData("llorar")]
		[InlineData("tener")]
		[InlineData("venir")]
		public void TestValidInfinitive(string v)
		{
			Assert.True(Verb.IsValidInfinitive(v));
		}


		[Theory]
		[InlineData("")]
		[InlineData("skank")]
		[InlineData("horror")]
		[InlineData(null)]
		[InlineData("xxx")]
		[InlineData("arararx")]
		[InlineData("a90210")]
		[InlineData(")*#FM*#$*#&@")]
		public void TestInvalidInfinitive(string v)
		{
			Assert.False(Verb.IsValidInfinitive(v));
		}
	}
}
