using Microsoft.AspNetCore.Mvc;
using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;
using WEB_253502_AKHMETOV.UI.Services.CategoryService;

namespace WEB_253502_AKHMETOV.UI.Services.ProductService
{
    public class MemoryProductService : IProductService
    {
        private readonly IConfiguration _configuration;
        List<Dish> _dishes;
        List<Category> _categories;


        public MemoryProductService([FromServices] IConfiguration configuration, ICategoryService categoryService)
        {
            _configuration = configuration;
            _categories = categoryService.GetCategoryListAsync().Result.Data!;

            SetupData();

        }

        private void SetupData()
        {
            this._dishes = new List<Dish>
            {
                new Dish { Id = 1, Name = "Суп-харчо",
                    Description = "Очень острый, невкусный",
                    Calories = 200,
                    ImagePath = "Images/harcho.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("soups"))
                },
                new Dish { Id = 2, Name = "Борщ",
                    Description = "Много сала, без сметаны",
                    Calories = 330,
                    ImagePath = "Images/ukr.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("soups"))
                },
                 new Dish { Id = 3, Name = "Vodka",
                    Description = "holodnaya charachka",
                    Calories = 228,
                    ImagePath = "Images/vodka.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("drinks"))
                },
                 new Dish { Id = 4, Name = "Coca-col",
                    Description = "holodnaya charachka",
                    Calories = 100,
                    ImagePath = "Images/cola.jpg",
                    Category = _categories.Find(c => c.NormalizedName.Equals("drinks"))
                },
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
            var itemsPerPage = Convert.ToInt32(_configuration.GetRequiredSection("ItemsPerPage").Value);

            var items = _dishes.Where(p => categoryNormalizedName == null || p.Category.NormalizedName.Equals(categoryNormalizedName)).ToList();

            var itemsCount = items.Count;

            items = items.Skip(itemsPerPage * (pageNo - 1)).Take(itemsPerPage).ToList();

            var totalPages = (int)Math.Floor((double)((categoryNormalizedName == null ? itemsCount : items.Count) / itemsPerPage));

            totalPages += ((categoryNormalizedName == null ? itemsCount : items.Count) % itemsPerPage == 0) ? 0 : 1;

            return Task.FromResult(new ResponseData<ListModel<Dish>>
            {
                Data = new ListModel<Dish>
                {
                    Items = items,
                    CurrentPage = pageNo,
                    TotalPages = totalPages,
                }
            });
           
            
        }

        public Task UpdateProductAsync(int id, Dish product, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }
    }
}
