using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Categoria que se va a devolver. Es decir una lista de todas las categorias de la base de datos.
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
