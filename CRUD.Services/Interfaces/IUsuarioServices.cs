using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Model;

namespace CRUD.Services.Interfaces
{
    public interface IUsuarioServices
    {
        Usuario GetUsuarioById(int id);

        void SalvarUsuario(Usuario usuario);

        void DeleteUsuarioById(int id);

        IEnumerable<Usuario> GetAllUsuario();
    }
}
