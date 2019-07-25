using FluentValidation;

namespace ValidarEntidades.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get;  set; }
        public int Idade { get; set; }


        //public Aluno(string _nome, string _email, int _idade)
        //{
        //    this.Nome = _nome;
        //    this.Email = _email;
        //    this.Idade = _idade;
        //}

        public class AlunoValidatior : AbstractValidator<Aluno>
        {
            public AlunoValidatior()
            {
                RuleFor(x => x.Nome).NotNull().Length(3, 40).WithMessage("Nome deve possuir de 3 a 40");
                RuleFor(x => x.Email).NotNull().EmailAddress().WithMessage("E-mail inválido.");
                RuleFor(x => x.Idade).NotNull().InclusiveBetween(18, 60).WithMessage("Idade entre 18 a 60 anos");
            }
         }
    }
}
