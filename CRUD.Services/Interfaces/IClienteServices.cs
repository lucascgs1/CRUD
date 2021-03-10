using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Model;

namespace CRUD.Services.Interfaces
{
    public interface IClienteServices
    {
        Cliente GetClienteById(long id);

        void SalvarCliente(Cliente cliente);

        void DeleteClienteById(long id);

        IEnumerable<Cliente> GetAllCliente();
    }
}
