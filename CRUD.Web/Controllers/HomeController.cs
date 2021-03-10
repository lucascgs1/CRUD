using CRUD.Services.Interfaces;
using CRUD.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Model;

namespace CRUD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// pagina inicial e listagem de usuario
        /// </summary>
        /// <param name="usuarioServices">servico de usuario</param>
        /// <returns></returns>
        public IActionResult Index([FromServices] IUsuarioServices usuarioServices)
        {

            IndexViewModel model = new IndexViewModel();
            model.LstUsuario = usuarioServices.GetAllUsuario().ToList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Usuario
        /// <summary>
        /// Pagina de detalhes do usuario e listagem de enderecos
        /// </summary>
        /// <param name="usuarioServices">servico de usuario</param>
        /// <param name="id">Codigo do usuario</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UsuarioDetalhe([FromServices] IUsuarioServices usuarioServices, int id)
        {
            UsuarioDetalheViewModel model = new UsuarioDetalheViewModel();

            Usuario usuario = usuarioServices.GetUsuarioById(id);

            if (usuario != null)
            {
                model = new UsuarioDetalheViewModel()
                {
                    Id = usuario.Id,
                    Email = usuario.Email,
                    Nome = usuario.Nome,
                    Telefone = usuario.Telefone,
                    LstEndereco = usuario.Enderecos,
                };
            }

            return View(model);
        }

        /// <summary>
        /// pagina de cadastro ou edicao de usuario
        /// </summary>
        /// <param name="usuarioServices">servico de usuario</param>
        /// <param name="id">codigo do usuario</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Cadastro([FromServices] IUsuarioServices usuarioServices, int id = 0)
        {
            CadastroUsuarioViewModel model = new CadastroUsuarioViewModel();

            if (id > 0)
            {
                Usuario usuario = usuarioServices.GetUsuarioById(id);

                if (usuario != null)
                    model = new CadastroUsuarioViewModel()
                    {
                        Id = usuario.Id,
                        Email = usuario.Email,
                        Nome = usuario.Nome,
                        Telefone = usuario.Telefone
                    };
            }

            return View(model);
        }

        /// <summary>
        /// Salva ou atualiza um endereco
        /// </summary>
        /// <param name="usuarioServices">servico de Usuario</param>
        /// <param name="model">dados do usuario</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SalvarUsuario([FromServices] IUsuarioServices usuarioServices, CadastroUsuarioViewModel model)
        {
            Usuario usuario = new Usuario()
            {
                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Telefone = model.Telefone,
            };

            usuarioServices.SalvarUsuario(usuario);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// deleta um usuario
        /// </summary>
        /// <param name="usuarioServices">servico de usuario</param>
        /// <param name="id">codigo do usuario</param>
        /// <returns></returns>
        public ActionResult DeleteUsuario([FromServices] IUsuarioServices usuarioServices, int id)
        {
            usuarioServices.DeleteUsuarioById(id);

            return RedirectToAction("Index");
        }
        #endregion

        #region endereco
        /// <summary>
        /// Pagina de cadastro ou atualizacao de endereco
        /// </summary>
        /// <param name="enderecoServices">servico de endereco</param>
        /// <param name="userId">codigo do usuario</param>
        /// <param name="id">codigo do endereco</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CadastroEndereco([FromServices] IEnderecoServices enderecoServices, int userId, int id = 0)
        {
            CadastroEnderecoViewModel model = new CadastroEnderecoViewModel(userId);

            if (id > 0)
            {
                Endereco endereco = enderecoServices.GetEnderecoById(id);

                if (endereco != null)
                    model = new CadastroEnderecoViewModel()
                    {
                        Id = endereco.Id,
                        UsuarioId = endereco.UsuarioId,
                        Titulo = endereco.Titulo,
                        Logradouro = endereco.Logradouro,
                        Numero = endereco.Numero,
                        Complemento = endereco.Complemento,
                        Bairro = endereco.Bairro,
                        Cidade = endereco.Cidade,
                        Estado = endereco.Estado,
                        EnderecoPrincipal = endereco.EnderecoPrincipal
                    };
            }

            return View(model);
        }

        /// <summary>
        /// Salva ou atualiza um endereco
        /// </summary>
        /// <param name="enderecoServices">servico de endereco</param>
        /// <param name="model">dados do endereco</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SalvarEndereco([FromServices] IEnderecoServices enderecoServices, CadastroEnderecoViewModel model)
        {
            Endereco endereco = new Endereco()
            {
                Id = model.Id,
                UsuarioId = model.UsuarioId,
                Titulo = model.Titulo,
                Logradouro = model.Logradouro,
                Complemento = model.Complemento,
                Numero = model.Numero,
                Bairro = model.Bairro,
                Cidade = model.Cidade,
                Estado = model.Estado,
                EnderecoPrincipal = model.EnderecoPrincipal,
            };

            enderecoServices.SalvarEndereco(endereco);

            return RedirectToAction("UsuarioDetalhe", new { id = model.UsuarioId });
        }

        /// <summary>
        /// Deleta um endereco
        /// </summary>
        /// <param name="enderecoServices">Servico de endereco</param>
        /// <param name="id">codigo do endereco</param>
        /// <param name="usuarioId">Codigo do usuario</param>
        /// <returns></returns>
        public ActionResult DeleteEndereco([FromServices] IEnderecoServices enderecoServices, int id, int usuarioId)
        {
            enderecoServices.DeleteEnderecoById(id);

            return RedirectToAction("UsuarioDetalhe", new { id = usuarioId });
        }
        #endregion
    }
}
