using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;

namespace WEB_253502_AKHMETOV.UI.Services.CategoryService
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

		private void SetupData() { 
			_dishes = new List<Dish>();
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
