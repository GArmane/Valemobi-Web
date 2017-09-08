namespace ValemobiWeb.Models
{
    public enum TipoNegocio
    {
        Compra,
        Venda
    }

    public class Mercadoria
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public TipoNegocio Negocio { get; set; }

        public Mercadoria() { }
        public Mercadoria(int id)
        {
            this.ID = id;
        }
    }
}