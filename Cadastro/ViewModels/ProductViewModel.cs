using Cadastro.Domain.Entities;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Active { get; set; }
        public int IdCategory { get; set; }
        public string Category { get; set; }
    }
}