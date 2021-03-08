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

        void DeleteEnderecoById(int id);
    }
}
