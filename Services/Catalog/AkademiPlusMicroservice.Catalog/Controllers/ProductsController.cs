using AkademiPlusMicroservice.Catalog.Dtos.ProductDto;
using AkademiPlusMicroservice.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllProducts()
		{
			var values = await _productService.GetAllProducts();
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			await _productService.CreateProduct(createProductDto);
			return Ok("Ürün Eklendi");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteProduct(string id)
		{
			await _productService.DeleteProduct(id);
			return Ok("Ürün Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			await _productService.UpdateProduct(updateProductDto);
			return Ok("Ürün Güncellendi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductById(string id)
		{
			var values = await _productService.GetByIdProduct(id);
			return Ok(values);
		}
	}
}
