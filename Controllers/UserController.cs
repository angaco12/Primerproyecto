using System.Runtime.Serialization.Json;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebAPI.Infrastructure.Models;
using AspNetCoreWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreWebAPI.Interface;
namespace AspNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase 
    {


        private readonly IUserRepository userRepository;

        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }


        [HttpGet]
        public ActionResult Get()
        {
            //ESTE ES EL VERBO PARA CONSULTAR INFORMACIÓN
            //POR LO GENERAL SE RECIBEN LOS DATOS EN EL HEADER O COMO QUERY STRING
            //QUERYSTRING ES UN VARIABLE AL FINAL DE LA CADE http
            //EJEMPLO: http://localhost:500/api/product?id=12021
            //ahí estarría haciendo un get osea una consulta sobre el 
            List<User> users = userRepository.GetUsers();
            return Ok(users);

        }

        [HttpPost]
        public ActionResult AddProduct([FromBody] User model)
        {
            //HTTPOST  ES EL VERBO PARA ALMACENAR INFORMACIÓN
            //EN ESTE PUEDE RECIBIR INFORMACIÓN A TRAVES DEL BODY DE LA PETICIÓN
            if(ModelState.IsValid){
                         userRepository.AddUser(model);
                         

            }
           

            return Ok(model);
        }

        [HttpPut]
        public ActionResult UpdateProduct([FromBody] User model)
        {
            //ESTE ES EL VERBO PARA ACTUALIZAR INFORMACIÓN
            //TAMBIEN PUEDE RECIBIR INFORMACIÓN EN EL BODY DE LA PEITICIÓN
              
             if (ModelState.IsValid){
                 
                 userRepository.UpdateUser(model);
             }
            return Ok(model);

        }

        [HttpDelete]
        public ActionResult DeleteProuct([FromBody] User user)
        {
            //ESTE ES EL VERBO PARA REFERIRSE A OPERACIONES DE BORRADO
            //TAMBIEN PUEDE RECIBIR INFORMACIÓN EN EL BODY
                userRepository.DeleteUser(user);
            return Ok(user);

        }
    }
}
