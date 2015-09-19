namespace eCommerce.Models
{
    public class Banco
    {

        public Catalogo lista()
        {
            /*
            System.Data.OleDb.OleDbConnection conn;
            
            OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\Catalogo.mdb;";

            Catalogo resp = new Catalogo();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new

                System.Data.OleDb.OleDbCommand();
                System.Data.OleDb.OleDbDataReader reader;
                comando.Connection = conn;
                comando.CommandText = "select * from Produtos";

                

                reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    Produto p = new Produto((int)reader["Codigo"],(string) reader["Nome"], (string) reader["Descricao"], (int)reader["Preco"]);
                    resp.lista.Add(p);

                }
                conn.Close();

            }
            catch
            {
                conn.Close();
                return null;
            }
            return resp;
            */
            Produto p = new Produto(1,"Livro","1000 páginas", 50.45);
            p.imglink = "https://okl1-scene7.insnw.net/is/image/OKL/fullbleed_41229?$story-full-bleed$";
            Produto p1 = new Produto(2,"Camisas","Em 3 tamanhos", 100);
            p1.imglink = "https://okl-scene7.insnw.net/is/image/OKL/fullbleed_53434?$story-full-bleed$"; 
            Produto p2 = new Produto(3,"Bicicleta","Entre na nova moda", 2000);
            p2.imglink = "https://okl-scene7.insnw.net/is/image/OKL/fullbleed_39719?$story-full-bleed$";
            Catalogo resp = new Catalogo();
            resp.lista.Add(p);
            resp.lista.Add(p1);
            resp.lista.Add(p2);
            return resp;
        }
    }
}