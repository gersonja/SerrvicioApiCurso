using LibraryProject.Helpers;
using Microsoft.AspNetCore.Mvc;
using SerrvicioApiCurso.Bll;
using SerrvicioApiCurso.Helpers;
using SerrvicioApiCurso.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SerrvicioApiCurso.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesServiceController : ControllerBase
    {

        CategoriesBll CategoryBll = new CategoriesBll();

        // GET: api/<CategoriesServiceController>
        [HttpGet]
        public IEnumerable<CategoriesServiceModel> Get()
        {
            List<CategoriesServiceModel> list = new List<CategoriesServiceModel>();

            return list;

        }

        // GET api/<CategoriesServiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            GenericResponseModel<CategoriesServiceModel?> response = new GenericResponseModel<CategoriesServiceModel?>();
            ValidateRequest ValidateReq = new ValidateRequest();

            if (!ValidateReq.ValidateId(id))
            {
                response.statusCode = 500;
                response.message = Message.IdNotValid;
            } else
            {
                CategoriesServiceModel CategoryModel = CategoryBll.GetCategory(id);
                if (CategoryModel == null)
                {
                    response.statusCode = 404;
                    response.message = Message.IdNotFound;
                }
                else
                {
                    response.statusCode = 200;
                    response.data = CategoryModel;
                    response.message = "";
                }
            }

            return StatusCode(response.statusCode, response);
        }

        // POST api/<CategoriesServiceController>
        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */

        // PUT api/<CategoriesServiceController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */

        // DELETE api/<CategoriesServiceController>/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
