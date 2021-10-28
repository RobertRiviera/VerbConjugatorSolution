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
			Assert.Equal("cantas", verb.Conjugate(tense, Person.T�));
			Assert.Equal("canta", verb.Conjugate(tense, Person.�l));
			Assert.Equal("cantamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("cant�is", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("cantan", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPresentTense_ER()
		{
			Verb verb = new Verb("aprender");
			Tense tense = Tense.Present;

			Assert.Equal("aprendo", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("aprendes", verb.Conjugate(tense, Person.T�));
			Assert.Equal("aprende", verb.Conjugate(tense, Person.�l));
			Assert.Equal("aprendemos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("aprend�is", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("aprenden", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPresentTense_IR()
		{
			Verb verb = new Verb("abrir");
			Tense tense = Tense.Present;

			Assert.Equal("abro", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("abres", verb.Conjugate(tense, Person.T�));
			Assert.Equal("abre", verb.Conjugate(tense, Person.�l));
			Assert.Equal("abrimos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("abr�s", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("abren", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_AR()
		{
			Verb verb = new Verb("hablar");
			Tense tense = Tense.Preterite;

			Assert.Equal("habl�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("hablaste", verb.Conjugate(tense, Person.T�));
			Assert.Equal("habl�", verb.Conjugate(tense, Person.�l));
			Assert.Equal("hablamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("hablasteis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("hablaron", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_ER()
		{
			Verb verb = new Verb("aprender");
			Tense tense = Tense.Preterite;

			Assert.Equal("aprend�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("aprendiste", verb.Conjugate(tense, Person.T�));
			Assert.Equal("aprendi�", verb.Conjugate(tense, Person.�l));
			Assert.Equal("aprendimos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("aprendisteis", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("aprendieron", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestPreteriteTense_IR()
		{
			Verb verb = new Verb("sufrir");
			Tense tense = Tense.Preterite;

			Assert.Equal("sufr�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("sufriste", verb.Conjugate(tense, Person.T�));
			Assert.Equal("sufri�", verb.Conjugate(tense, Person.�l));
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
			Assert.Equal("bailabas", verb.Conjugate(tense, Person.T�));
			Assert.Equal("bailaba", verb.Conjugate(tense, Person.�l));
			Assert.Equal("bail�bamos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("bailabais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("bailaban", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestImperfectTense_ER()
		{
			Verb verb = new Verb("vender");
			Tense tense = Tense.Imperfect;

			Assert.Equal("vend�a", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("vend�as", verb.Conjugate(tense, Person.T�));
			Assert.Equal("vend�a", verb.Conjugate(tense, Person.�l));
			Assert.Equal("vend�amos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("vend�ais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("vend�an", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestImperfectTense_IR()
		{
			Verb verb = new Verb("vivir");
			Tense tense = Tense.Imperfect;

			Assert.Equal("viv�a", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("viv�as", verb.Conjugate(tense, Person.T�));
			Assert.Equal("viv�a", verb.Conjugate(tense, Person.�l));
			Assert.Equal("viv�amos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("viv�ais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("viv�an", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_AR()
		{
			Verb verb = new Verb("cantar");
			Tense tense = Tense.Conditional;

			Assert.Equal("cantar�a", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("cantar�as", verb.Conjugate(tense, Person.T�));
			Assert.Equal("cantar�a", verb.Conjugate(tense, Person.�l));
			Assert.Equal("cantar�amos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("cantar�ais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("cantar�an", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_ER()
		{
			Verb verb = new Verb("conocer");
			Tense tense = Tense.Conditional;

			Assert.Equal("conocer�a", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("conocer�as", verb.Conjugate(tense, Person.T�));
			Assert.Equal("conocer�a", verb.Conjugate(tense, Person.�l));
			Assert.Equal("conocer�amos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("conocer�ais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("conocer�an", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestConditionalTense_IR()
		{
			Verb verb = new Verb("vivir");
			Tense tense = Tense.Conditional;

			Assert.Equal("vivir�a", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("vivir�as", verb.Conjugate(tense, Person.T�));
			Assert.Equal("vivir�a", verb.Conjugate(tense, Person.�l));
			Assert.Equal("vivir�amos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("vivir�ais", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("vivir�an", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_AR()
		{
			Verb verb = new Verb("tratar");
			Tense tense = Tense.Future;

			Assert.Equal("tratar�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("tratar�s", verb.Conjugate(tense, Person.T�));
			Assert.Equal("tratar�", verb.Conjugate(tense, Person.�l));
			Assert.Equal("trataremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("tratar�is", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("tratar�n", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_ER()
		{
			Verb verb = new Verb("correr");
			Tense tense = Tense.Future;

			Assert.Equal("correr�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("correr�s", verb.Conjugate(tense, Person.T�));
			Assert.Equal("correr�", verb.Conjugate(tense, Person.�l));
			Assert.Equal("correremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("correr�is", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("correr�n", verb.Conjugate(tense, Person.Ellos));
		}

		[Fact]
		public void TestFutureTense_IR()
		{
			Verb verb = new Verb("sequir");
			Tense tense = Tense.Future;

			Assert.Equal("sequir�", verb.Conjugate(tense, Person.Yo));
			Assert.Equal("sequir�s", verb.Conjugate(tense, Person.T�));
			Assert.Equal("sequir�", verb.Conjugate(tense, Person.�l));
			Assert.Equal("sequiremos", verb.Conjugate(tense, Person.Nosotros));
			Assert.Equal("sequir�is", verb.Conjugate(tense, Person.Vosotros));
			Assert.Equal("sequir�n", verb.Conjugate(tense, Person.Ellos));
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
