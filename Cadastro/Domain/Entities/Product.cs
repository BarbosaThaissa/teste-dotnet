namespace Cadastro.Domain.Entities
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Active { get; set; }
        public int IdCategory { get; set; }
        public Category Category { get; set; }
    }
}
