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
    public class UsersServiceController : ControllerBase
    {
    /*
        UsuarioBll UserBll = new UsuarioBll();

        // GET: api/<UsuariosController>
        [HttpGet]
        public List<UsersServiceModel> Get()
        {
            List<UsersServiceModel> ListUser = UserBll.GetUsuarios();

            return ListUser;

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            GenericResponseModel<UsersServiceModel?> GenResp = new Models.GenericResponseModel<UsersServiceModel?>();
            ValidateRequest ValidateReq = new ValidateRequest();

            if (!ValidateReq.ValidateId(id))
            {
                GenResp.statusCode = 500;
                GenResp.message = Message.IdNotValid;
            }
            else
            {

                UsersServiceModel UserModel = UserBll.GetUser(id);

                if (UserModel == null)
                {
                    GenResp.statusCode = 404;
                    GenResp.message = Message.IdNotFound;
                }
                else
                {
                    GenResp.statusCode = 200;
                    GenResp.data = UserModel;
                    GenResp.message = "";
                }
            }

            return StatusCode(GenResp.statusCode, GenResp);

            //return UserModel;
            //return StatusCode(200, UserModel);
            //return Ok(UserModel);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    */
    }
}
