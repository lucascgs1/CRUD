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

        public Usuario GetUsuarioById(int id)
        {
            return UsuarioRepository.GetById(id);
        }
    }
}