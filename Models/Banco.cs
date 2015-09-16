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
            Produto p = new Produto(1,"Livro","1000 páginas", 50);
            p.imglink = "http://www.bantumen.com/wp-content/uploads/2015/08/livro-imagem.jpg";
            Produto p1 = new Produto(2,"Camista","Em 3 tamanhos", 100);
            p1.imglink = "https://www.camisetasimportadas.com/product_images/uploaded_images/camisa_negra_mh780.jpg"; 
            Produto p2 = new Produto(3,"Bicicleta","Entre na nova moda", 2000);
            p2.imglink = "http://i4-decathlon.a8e.net.br/gg/bicicleta-infantil-aro-24--caloi-wild_2437605_1926989.JPG";
            Catalogo resp = new Catalogo();
            resp.lista.Add(p);
            resp.lista.Add(p1);
            resp.lista.Add(p2);
            return resp;
        }
    }
}