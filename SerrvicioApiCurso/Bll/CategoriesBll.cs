using SerrvicioApiCurso.Models;

namespace SerrvicioApiCurso.Bll
{
    public class CategoriesBll
    {

        List<CategoriesServiceModel> ListCategories = new List<CategoriesServiceModel>
        {
            new CategoriesServiceModel { Id = 1, Name = "Electrónicos", Created = new DateOnly(2024,01,01)},
            new CategoriesServiceModel { Id = 2, Name = "Libros", Created = new DateOnly(2024,01,01) },
            new CategoriesServiceModel { Id = 3, Name = "Ropa", Created = new DateOnly(2024,01,01) },
            new CategoriesServiceModel { Id = 4, Name = "Alimentos", Created = new DateOnly(2024,01,01) },
            new CategoriesServiceModel { Id = 5, Name = "Muebles", Created = new DateOnly(2024,01,01) }
        };

        public List<CategoriesServiceModel> GetCategories()
        {
            return ListCategories;
        }

        public CategoriesServiceModel GetCategory(int Id)
        {
            try
            {
                return ListCategories.Where(x => x.Id == Id).First();
            } catch 
            {
                return null;
            }
        }

    }
}
