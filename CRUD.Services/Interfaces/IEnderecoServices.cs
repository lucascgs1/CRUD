using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Model;

namespace CRUD.Services.Interfaces
{
    public interface IEnderecoServices
    {
        Endereco GetEnderecoById(int id);

        void SalvarEndereco(Endereco endereco);

        IEnumerable<Endereco> GetAllEndereco();

        //IEnumerable<Endereco> GetAllEnderecoByUserId(int userId);

        void DeleteEnderecoById(int id);
    }
}
