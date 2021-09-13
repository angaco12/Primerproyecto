using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public ProductController()
        {
            
        }

        [HttpGet]
        public ActionResult Get()
        {
            //ESTE ES EL VERBO PARA CONSULTAR INFORMACIÓN
            //POR LO GENERAL SE RECIBEN LOS DATOS EN EL HEADER O COMO QUERY STRING
            //QUERYSTRING ES UN VARIABLE AL FINAL DE LA CADE http
            //EJEMPLO: http://localhost:500/api/product?id=12021
            //ahí estarría haciendo un get osea una consulta sobre el 
            //producto con el id 12021
            return Ok("PRUEBA ANGACO");
            
        }

        [HttpPost]
        public ActionResult AddProduct()
        {
            //HTTPOST  ES EL VERBO PARA ALMACENAR INFORMACIÓN
            //EN ESTE PUEDE RECIBIR INFORMACIÓN A TRAVES DEL BODY DE LA PETICIÓN
            return Ok("PRUEBA ANGACO");
            
        }

        [HttpPut]
        public ActionResult UpdateProduct()
        {
            //ESTE ES EL VERBO PARA ACTUALIZAR INFORMACIÓN
            //TAMBIEN PUEDE RECIBIR INFORMACIÓN EN EL BODY DE LA PEITICIÓN
            return Ok("PRUEBA ANGACO");
            
        }

        [HttpDelete]
        public ActionResult DeleteProuct()
        {
            //ESTE ES EL VERBO PARA REFERIRSE A OPERACIONES DE BORRADO
            //TAMBIEN PUEDE RECIBIR INFORMACIÓN EN EL BODY
            return Ok("PRUEBA ANGACO");
            
        }
    }
}
