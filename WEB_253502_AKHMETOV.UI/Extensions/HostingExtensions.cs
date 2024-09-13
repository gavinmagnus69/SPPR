using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using WEB_253502_AKHMETOV.UI.Services.CategoryService;
using WEB_253502_AKHMETOV.UI.Services.ProductService;
namespace WEB_253502_AKHMETOV.UI.Extensions
{
    public static class HostingExtensions
	{
		public static void RegisterCustomServices(this WebApplicationBuilder builder)
		{
			builder.Services.AddScoped<ICategoryService, MemoryCategoryService>();

			builder.Services.AddScoped<IProductService, MemoryProductService>();
		
		}
	}
}
