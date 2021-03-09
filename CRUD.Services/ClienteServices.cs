using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Data.Interfaces;
using CRUD.Model;
using CRUD.Services.Interfaces;

namespace CRUD.Services
{
    public class ClienteServices : IClienteServices
    {
        public IClienteRepository ClienteRepository { get; set; }

        public ClienteServices(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return ClienteRepository.GetAll();
        }

        public Cliente GetClienteById(long id)
        {
            return ClienteRepository.GetById(id);
        }

        public void SalvarCliente(Cliente cliente)
        {
            ClienteRepository.Save(cliente);
        }

        public void DeleteClienteById(long id)
        {
            ClienteRepository.Remove(id);
        }
    }
}