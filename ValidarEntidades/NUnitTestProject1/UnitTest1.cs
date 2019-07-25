using FluentValidation.TestHelper;
using NUnit.Framework;
using static ValidarEntidades.Models.Aluno;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private AlunoValidatior validator;
        public object BaseVerifiersSetComposer { get; private set; }

        [SetUp]
        public void Setup()
        {
            validator = new AlunoValidatior();
        }

        [Test]
        public void VerificarSeContemNulo()
        {
            validator.ShouldHaveValidationErrorFor(Aluno => Aluno.Nome, null as string);
        }

        [Test]
        public void VerificarSeContemAte3Caracteres()
        {
            validator.ShouldNotHaveValidationErrorFor(Aluno => Aluno.Nome, "Hamilton Vale");
        }

        [Test]
        public void VerificandoIdadeMinimaMaxima()
        {
            validator.ShouldNotHaveValidationErrorFor(Aluno => Aluno.Idade, 1);
        }
    }
}