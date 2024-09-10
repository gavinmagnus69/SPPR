using WEB_253502_AKHMETOV.Domain.Models;
using WEB_253502_AKHMETOV.Domain.Entities;


namespace WEB_253502_AKHMETOV.UI.Services.CategoryService
{
	public interface IProductService
	{

		public Task<ResponseData<ListModel<Dish>>> GetProductListAsync(string? categoryNormalizedName, int pageNo = 1);

		public Task<ResponseData<Dish>> GetProductByIdAsync(int id);

		public Task UpdateProductAsync(int id, Dish product, IFormFile? formFile);

		public Task DeleteProductAsync(int id);

		public Task<ResponseData<Dish>> CreateProductAsync(Dish product, IFormFile? formFile);
	}
}
