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

        public Cliente GetClienteById(int id)
        {
            return ClienteRepository.GetById(id);
        }

        public void SalvarCliente(Cliente cliente)
        {
            if (cliente.Id > 0)
                ClienteRepository.Update(cliente);
            else
                ClienteRepository.Add(cliente);
        }

        public void DeleteClienteById(int id)
        {
            ClienteRepository.Remove(id);
        }
    }
}