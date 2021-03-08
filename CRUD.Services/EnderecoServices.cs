using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Data.Interfaces;
using CRUD.Model;
using CRUD.Services.Interfaces;

namespace CRUD.Services
{
    public class EnderecoServices : IEnderecoServices
    {
        public IEnderecoRepository EnderecoRepository { get; set; }

        public EnderecoServices(IEnderecoRepository enderecoRepository)
        {
            EnderecoRepository = enderecoRepository;
        }

        public Endereco GetEnderecoById(int id)
        {
            return EnderecoRepository.GetById(id);
        }

        public void SalvarEndereco(Endereco endereco)
        {
            if (endereco.Id > 0)
                EnderecoRepository.Update(endereco);
            else
                EnderecoRepository.Add(endereco);
        }

        public IEnumerable<Endereco> GetAllEndereco()
        {
            return EnderecoRepository.GetAll();
        }

        public void DeleteEnderecoById(int id)
        {
            EnderecoRepository.Remove(id);
        }
    }


}