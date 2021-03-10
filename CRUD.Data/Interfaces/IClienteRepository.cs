using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetById(long id);

        void Remove(long id);

        void Save(Cliente cliente);
    }
}
