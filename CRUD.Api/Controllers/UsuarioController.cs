using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Model;
using CRUD.Services.Interfaces;



namespace CRUD.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// obtem todos os usuarios cadastrados
        /// </summary>
        /// <param name="UsuarioServices"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Get([FromServices] IUsuarioServices UsuarioServices)
        {
            try
            {
                var usuarios = UsuarioServices.GetUsuarioById(1);

                //var usuarios = new List<Usuario> ();

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// adicionar novo usuario
        /// </summary>
        /// <param name="UsuarioServices">servico de usuario</param>
        /// <param name="Usuario">objeto recebido no corpo da requisicao</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Put([FromServices] IUsuarioServices UsuarioServices, [FromBody] Usuario Usuario)
        {
            try
            {
                //UsuarioServices.insert(Usuario);



                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }
    }
}
