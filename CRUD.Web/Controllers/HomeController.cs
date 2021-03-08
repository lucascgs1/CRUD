using CRUD.Services.Interfaces;
using CRUD.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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


        public ActionResult Cadastro([FromServices] IUsuarioServices usuarioServices, int id = 0)
        {
            var usuarios = usuarioServices.GetAllUsuario().ToList();
            CadastroViewModel model = new CadastroViewModel();

            if (id > 0)
            {
                Usuario usuario = usuarioServices.GetUsuarioById(id);

                if (usuario != null)
                    model = new CadastroViewModel()
                    {
                        id = usuario.Id,
                        Email = usuario.Email,
                        Nome = usuario.Nome,
                        Telefone = usuario.Telefone
                    };
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult SalvarUsuario([FromServices] IUsuarioServices usuarioServices, CadastroViewModel model)
        {
            Usuario usuario = new Usuario()
            {
                Id = model.id,
                Nome = model.Nome,
                Email = model.Email,
                Telefone = model.Telefone,
            };

            usuarioServices.SalvarUsuario(usuario);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteUsuario([FromServices] IUsuarioServices usuarioServices, int id)
        {
            usuarioServices.DeleteUsuarioById(id);

            return RedirectToAction("Index");
        }



        public ActionResult CadastroEndereco([FromServices] IEnderecoServices enderecoServices, int id = 0)
        {
            EnderecoViewModel model = new EnderecoViewModel();

            if (id > 0)
            {
                Endereco endereco = enderecoServices.GetEnderecoById(id);

                if (endereco != null)
                    model = new EnderecoViewModel()
                    {
                        Id = model.Id,
                        UsuarioId = model.UsuarioId,
                        Titulo = model.Titulo,
                        Logradouro = model.Logradouro,
                        Numero = model.Numero,
                        Complemento = model.Complemento,
                        Bairro = model.Bairro,
                        Cidade = model.Cidade,
                        Estado = model.Estado,
                        EnderecoPrincipal = model.EnderecoPrincipal
                    };
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult SalvarEndereco([FromServices] IEnderecoServices enderecoServices, EnderecoViewModel model)
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

            return RedirectToAction("Index");
        }

        public ActionResult DeleteEndereco([FromServices] IEnderecoServices enderecoServices, int id)
        {
            enderecoServices.DeleteEnderecoById(id);

            return RedirectToAction("Index");
        }
    }
}
