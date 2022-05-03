namespace Revendas.Api.Models
{
    public class Revenda
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public decimal Saldo { get; set; }  
    }
}
