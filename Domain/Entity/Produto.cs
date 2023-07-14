namespace Domain.Entity
{
    public class Produto: BaseDomain
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int TipoId { get; set; }
        public int Tamanho { get; set; }
        public double Preco { get; set; }
        public Tipo? Tipo { get; set; }
    }
}
