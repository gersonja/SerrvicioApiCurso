using Microsoft.AspNetCore.Mvc;
using SerrvicioApiCurso.Models;
using SerrvicioApiCurso.Bll;
using SerrvicioApiCurso.Helpers;
using LibraryProject.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SerrvicioApiCurso.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsServiceController : ControllerBase
    {

        ProductsBll ProductBll
            = new ProductsBll(); 

        // GET: api/<ProductsServiceController>
        [HttpGet("names")]
        public List<String> Get()
        {
            List<String> products = ProductBll.GetProductsName();

            return products;
        }

        // GET api/<ProductsServiceController>/5
        /*
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            GenericResponseModel<ProductsServiceModel?> GenResp = new GenericResponseModel<ProductsServiceModel?>();
            ValidateRequest ValidateReq = new ValidateRequest();

            if (!ValidateReq.ValidateId(id))
            {
                GenResp.statusCode = 500;
                GenResp.message = Message.IdNotValid;
            }
            else
            {
                
                ProductsServiceModel ProductModel = ProductBll.GetProduct(id);

                if (ProductModel == null)
                {
                    GenResp.statusCode = 404;
                    GenResp.message= Message.IdNotFound;
                }
                else
                {
                    GenResp.statusCode = 200;
                    GenResp.data = ProductModel;
                    GenResp.message = "";
                }

            }

            return StatusCode(GenResp.statusCode, GenResp);

        }
        */
        [HttpGet("category/{id}")]
        public IActionResult GetCategory(int id)
        {

            GenericResponseModel<List<ProductsServiceModel>?> GenResp = new GenericResponseModel<List<ProductsServiceModel>?>();
            ValidateRequest ValidateReq = new ValidateRequest();

            if (!ValidateReq.ValidateId(id))
            {
                GenResp.statusCode = 500;
                GenResp.message = Message.IdNotValid;
            }
            else
            {

                List<ProductsServiceModel> ProductsName = ProductBll.GetProductsbyCategory(id);

                if (!ProductsName.Any())
                {
                    GenResp.statusCode = 404;
                    GenResp.message= Message.IdNotFound;
                }
                else
                {
                    GenResp.statusCode = 200;
                    GenResp.data = ProductsName;
                    GenResp.message = "";
                }

            }

            return StatusCode(GenResp.statusCode, GenResp);
        }

        // POST api/<ProductsServiceController>
        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */

        // PUT api/<ProductsServiceController>/5
        /*
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */

        // DELETE api/<ProductsServiceController>/5
        /*
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
