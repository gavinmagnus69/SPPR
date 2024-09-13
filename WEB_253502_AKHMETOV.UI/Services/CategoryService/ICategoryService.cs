using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;

namespace WEB_253502_AKHMETOV.UI.Services.CategoryService
{
	public interface ICategoryService
	{
		public Task<ResponseData<List<Category>>> GetCategoryListAsync();
	}
}
