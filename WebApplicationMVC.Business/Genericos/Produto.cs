using System.Data.SqlClient;
using WebApplicationMVC.Business.Utils;

namespace WebApplicationMVC.Business.Genericos
{
    public class Produto
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set;}
        public int Categoria { get; set; }


        public static List<Produto> Read()
        {
            var result = new List<Produto>();

            using (var conn = new SqlConnection(DBConnect.GetDBConnection()))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID, NOME, DESCRICAO,PRECO, CATEGORIA FROM PRODUTOS";

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto()
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Descricao = reader.GetString(2),
                        Preco = reader.GetDecimal(3),
                        Categoria = reader.GetInt32(4)
                    };
                    result.Add(produto);
                }
            }
            return result;

        }
        //public static Produto Read(long id)
        //{

        //}

        //public static bool Add(Produto produto)
        //{

        //}

        //public static bool Update(Produto produto)
        //{

        //}

        //public static bool Delete(long id)
        //{

        //}


    }
    
}