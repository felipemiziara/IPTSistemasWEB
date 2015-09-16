namespace eCommerce.Models
{
    public class Banco
    {

        public Catalogo lista()
        {
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
        }
    }
}