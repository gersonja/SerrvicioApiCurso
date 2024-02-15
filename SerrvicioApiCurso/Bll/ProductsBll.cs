using SerrvicioApiCurso.Models;

namespace SerrvicioApiCurso.Bll
{
    public class ProductsBll
    {

        List<ProductsServiceModel> ListProducts = new List<ProductsServiceModel>
        {
            new ProductsServiceModel { Id = 1, Name = "Laptop", Price = 999.99m, Quanty = 10, Created = new DateOnly(2024,02,15), CategoryId = 1 },
            new ProductsServiceModel { Id = 2, Name = "Mouse", Price = 19.99m, Quanty = 50, Created = new DateOnly(2024,02,15), CategoryId = 1 },
            new ProductsServiceModel { Id = 3, Name = "Libro de C#", Price = 39.99m, Quanty = 5, Created = new DateOnly(2024,02,15), CategoryId = 2 },
            new ProductsServiceModel { Id = 4, Name = "Novela de misterio", Price = 14.99m, Quanty = 20, Created = new DateOnly(2024,02,15), CategoryId = 2 },
            new ProductsServiceModel { Id = 5, Name = "Camiseta", Price = 9.99m, Quanty = 100, Created = new DateOnly(2024,02,15), CategoryId = 3 },
            new ProductsServiceModel { Id = 6, Name = "Jeans", Price = 49.99m, Quanty = 30, Created = new DateOnly(2024,02,15), CategoryId = 3 },
            new ProductsServiceModel { Id = 7, Name = "Pan", Price = 1.99m, Quanty = 200, Created = new DateOnly(2024,02,15), CategoryId = 4 },
            new ProductsServiceModel { Id = 8, Name = "Leche", Price = 0.99m, Quanty = 50, Created = new DateOnly(2024,02,15), CategoryId = 4 },
            new ProductsServiceModel { Id = 9, Name = "Sofá", Price = 299.99m, Quanty = 5, Created = new DateOnly(2024,02,15), CategoryId = 5 },
            new ProductsServiceModel { Id = 10, Name = "Mesa", Price = 99.99m, Quanty = 10, Created = new DateOnly(2024,02,15), CategoryId = 5 },
            new ProductsServiceModel { Id = 11, Name = "Monitor", Price = 199.99m, Quanty = 15, Created = new DateOnly(2024,02,15), CategoryId = 1 },
            new ProductsServiceModel { Id = 12, Name = "Teclado", Price = 29.99m, Quanty = 35, Created = new DateOnly(2024,02,15), CategoryId = 1 },
            new ProductsServiceModel { Id = 13, Name = "Libro de Python", Price = 49.99m, Quanty = 10, Created = new DateOnly(2024,02,15), CategoryId = 2 },
            new ProductsServiceModel { Id = 14, Name = "Novela de aventuras", Price = 19.99m, Quanty = 25, Created = new DateOnly(2024,02,15), CategoryId = 2 },
            new ProductsServiceModel { Id = 15, Name = "Chaqueta", Price = 59.99m, Quanty = 20, Created = new DateOnly(2024,02,15), CategoryId = 3 },
            new ProductsServiceModel { Id = 16, Name = "Zapatos", Price = 79.99m, Quanty = 30, Created = new DateOnly(2024,02,15), CategoryId = 3 },
            new ProductsServiceModel { Id = 17, Name = "Queso", Price = 2.99m, Quanty = 50, Created = new DateOnly(2024,02,15), CategoryId = 4 },
            new ProductsServiceModel { Id = 18, Name = "Vino", Price = 14.99m, Quanty = 60, Created = new DateOnly(2024,02,15), CategoryId = 4 },
            new ProductsServiceModel { Id = 19, Name = "Silla", Price = 49.99m, Quanty = 10, Created = new DateOnly(2024,02,15), CategoryId = 5 },
            new ProductsServiceModel { Id = 20, Name = "Escritorio", Price = 149.99m, Quanty = 5, Created = new DateOnly(2024,02,15), CategoryId = 5 }
        };

        public List<ProductsServiceModel> GetProducts()
        {
            return ListProducts.ToList();
        }

        public ProductsServiceModel GetProduct(int Id)
        {
            try
            {
                return ListProducts.Where(x => x.Id == Id).First();
            } catch
            {
                return null;
            }
        }

        public List<ProductsServiceModel> GetProductsbyCategory(int Id)
        {
            return ListProducts.Where(x => x.CategoryId == Id).ToList();
        }

        public List<String> GetProductsName()
        {
            return ListProducts.Select(x => x.Name).ToList();
        }


    }
}
