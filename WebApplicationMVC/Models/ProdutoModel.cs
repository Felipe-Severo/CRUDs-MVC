using WebApplicationMVC.Business.Genericos;

namespace WebApplicationMVC.Models
{
    public class ProdutoModel
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Categoria { get; set; }

        public ProdutoModel()
        {
            
        }

        public ProdutoModel(Produto produto)
        {
            Id = produto.Id;
            Nome = produto.Nome;
            Descricao = produto.Descricao;
            Preco = produto.Preco;
            Categoria = produto.Categoria;
        }
    }
}