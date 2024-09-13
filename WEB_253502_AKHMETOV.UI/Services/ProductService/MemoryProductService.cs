using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;
using WEB_253502_AKHMETOV.UI.Services.CategoryService;

namespace WEB_253502_AKHMETOV.UI.Services.ProductService
{
    public class MemoryProductService : IProductService
    {

        List<Dish> _dishes;
        List<Category> _categories;


        public MemoryProductService(ICategoryService categoryService)
        {
            _categories = categoryService.GetCategoryListAsync().Result.Data;

            SetupData();

        }

        private void SetupData()
        {
            _dishes = new List<Dish>()
            {
                new Dish { Id = 1, Name = "Суп-харчо",
                    Description = "Очень острый, невкусный",
                    Calories = 200, Image = "Images/Суп.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("soups"))
                },
                new Dish { Id = 2, Name = "Борщ",
                    Description = "Много сала, без сметаны",
                    Calories = 330, Image = "Images/Борщ.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("soups"))
                }




            };
        }
        public Task<ResponseData<Dish>> CreateProductAsync(Dish product, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<Dish>> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<ListModel<Dish>>> GetProductListAsync(string? categoryNormalizedName, int pageNo = 1)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(int id, Dish product, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }
    }
}
