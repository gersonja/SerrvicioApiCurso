namespace SerrvicioApiCurso.Models
{
    public class ProductsServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quanty { get; set; }
        public DateOnly Created {  get; set; }
        public int CategoryId { get; set; }
    }
}
