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
            EnderecoRepository.Save(endereco);
        }

        public IEnumerable<Endereco> GetAllEndereco()
        {
            return EnderecoRepository.GetAll();
        }

        public IEnumerable<Endereco> GetAllEnderecoByUserId(int userId)
        {
            return EnderecoRepository.GetAllEnderecosByUserId(userId);
        }

        public void DeleteEnderecoById(int id)
        {
            EnderecoRepository.Remove(id);
        }
    }


}