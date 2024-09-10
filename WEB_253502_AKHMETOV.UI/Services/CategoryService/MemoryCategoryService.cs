using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;

namespace WEB_253502_AKHMETOV.UI.Services.CategoryService
{
	public class MemoryCategoryService : ICategoryService
	{
		public Task<ResponseData<List<Category>>> GetCategoryListAsync() {
			var categories = new List<Category> {
				new Category { Id = 1, Name = "Стартеры", NormalizedName = "starters"},
				new Category { Id = 2, Name = "Супы", NormalizedName = "soups"},
				new Category { Id = 3, Name = "Основные блюда", NormalizedName = "main-dishes"},
				new Category { Id = 4, Name = "Напитки", NormalizedName = "drinks"},
				new Category { Id = 5, Name = "Десерты", NormalizedName = "desserts"},
			};

			var result =  ResponseData<List<Category>>.Success(categories);

			return Task.FromResult(result);
		}
	}
}
