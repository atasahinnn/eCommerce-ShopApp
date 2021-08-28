using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entity;
using ShopApp.WEBAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBAPI.Controllers
{
    //ISSEXPRESS/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task <IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();
            var productsDTO = new List<ProductDTO>();

            foreach (var product in products)
            {
                productsDTO.Add(ProductToDTO(product));
            }

            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetByID(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            return Ok(ProductToDTO(product));

        }

        [HttpPost]
        public async Task <IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, ProductToDTO(entity));
        }

        //localhost:5000/api/products/2 etc.
        [HttpPut("{id}")]
        public async Task <IActionResult> UpdateProduct(int id, Product entity)
        {
            if (id! == entity.ProductId)
            {
                return BadRequest();
            }

            var product = await _productService.GetByID(id);

            if (product == null)
            {
                return NotFound();
            }

            await _productService.UpdateAsync(product, entity);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetByID(id);

            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteAsync(product);
            return NoContent();
        }

        private static ProductDTO ProductToDTO(Product product)
        {
            return new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Url = product.Url,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl
            };
        }
    }
}
