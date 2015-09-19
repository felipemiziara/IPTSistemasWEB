namespace eCommerce.Models
{
    public class Produto
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string detalhes {get; set;}
        public double preco {get; set;}
        public string imglink {get; set;}
        public Produto(){
            
        }
        public Produto(int id, string nome, string detalhes, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.detalhes = detalhes;
            this.preco = preco;
            this.imglink = null;
        }
        public Produto(int id, string nome, string detalhes, double preco, string imglink):this(id, nome, detalhes, preco){
            this.imglink = imglink;
        }
    }
}