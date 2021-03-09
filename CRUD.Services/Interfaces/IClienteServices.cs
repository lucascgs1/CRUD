using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Model;

namespace CRUD.Services.Interfaces
{
    public interface IClienteServices
    {
        Cliente GetClienteById(int id);

        void SalvarCliente(Cliente cliente);

        void DeleteClienteById(int id);

        IEnumerable<Cliente> GetAllCliente();
    }
}
