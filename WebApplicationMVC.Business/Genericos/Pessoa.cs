namespace WebApplicationMVC.Business.Genericos
{
    public class Pessoa
    {
        private static long _currentId = 0;
        public static List<Pessoa> PessoasCadastradas = new List<Pessoa>()
        {
            new Pessoa()
            {
                Nome = "Marco A. Angelo",
            },
            new Pessoa()
            {
                Nome = "Joãozinho",
            },
            new Pessoa()
            {
                Nome = "Mariazinha",
            },
        };

        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public Pessoa()
        {
            Id = ++_currentId;
        }
    }
}
