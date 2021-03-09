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
        /// <param name="usuarioServices"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Get([FromServices] IUsuarioServices usuarioServices, [FromQuery] int id)
        {
            try
            {
                var usuarios = usuarioServices.GetUsuarioById(id);

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }
         
        /// <summary>
        /// obtem todos os usuarios cadastrados
        /// </summary>
        /// <param name="usuarioServices"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetAllUsuario([FromServices] IUsuarioServices usuarioServices)
        {
            try
            {
                var usuarios = usuarioServices.GetAllUsuario();

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Salva um novo Usuario
        /// </summary>
        /// <param name="usuarioServices">servico do usuario</param>
        /// <param name="usuario">Dados do usuario</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Put([FromServices] IUsuarioServices usuarioServices, [FromBody] Usuario usuario)
        {
            try
            {
                usuarioServices.SalvarUsuario(usuario);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Salvar ou atualizar um usuario
        /// </summary>
        /// <param name="usuarioServices">servico de usuario</param>
        /// <param name="usuario">Dados do usuario</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Post([FromServices] IUsuarioServices usuarioServices, [FromBody] Usuario usuario)
        {
            try
            {
                usuarioServices.SalvarUsuario(usuario);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="usuarioServices">Servico de usuario</param>
        /// <param name="id">codigo do usuario</param>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Delete([FromServices] IUsuarioServices usuarioServices, [FromQuery] int id)
        {
            try
            {
                usuarioServices.DeleteUsuarioById(id);

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
