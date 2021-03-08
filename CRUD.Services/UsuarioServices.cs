using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Data.Interfaces;
using CRUD.Model;
using CRUD.Services.Interfaces;

namespace CRUD.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        public IUsuarioRepository UsuarioRepository { get; set; }

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> GetAllUsuario()
        {
            return UsuarioRepository.GetAll();
        }

        public Usuario GetUsuarioById(int id)
        {
            return UsuarioRepository.GetById(id);
        }

        public void SalvarUsuario(Usuario usuario)
        {
            if (usuario.Id > 0)
                UsuarioRepository.Update(usuario);
            else
                UsuarioRepository.Add(usuario);
        }

        public void DeleteUsuarioById(int id)
        {
            UsuarioRepository.Remove(id);
        }
    }
}