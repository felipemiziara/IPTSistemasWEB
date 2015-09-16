namespace eCommerce.Models
{
    public class Produto
    {
        public int id;
        public string nome;
        public string detalhes;
        public int preco;
        public Produto(int id, string nome, string detalhes, int preco)
        {
            this.id = id;
            this.nome = nome;
            this.detalhes = detalhes;
            this.preco = preco;
        }
    }
}