namespace DataShift.Produtos
{
    public class Produtos
    {
        public int ID_PRODUTO { get; set; }
        public string NOME { get; set; }
        public string CATEGORIA { get; set; }
        public decimal PESO { get; set; }
        public decimal PRECO { get; set; }
        public int ID_USUARIO_PRODUTO  { get; set; }


        public Produtos() { }

        public Produtos(string NOME, string CATEGORIA, decimal PESO, decimal PRECO, int ID_USUARIO_PRODUTO)
        {
            this.NOME = NOME;
            this.CATEGORIA = CATEGORIA;
            this.PESO = PESO;
            this.PRECO = PRECO;
            this.ID_USUARIO_PRODUTO = ID_USUARIO_PRODUTO;
        }
    }
}