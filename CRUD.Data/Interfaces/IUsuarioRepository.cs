using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario GetUsuarioById(int id);

        void Save(Usuario usuario);
    }
}
