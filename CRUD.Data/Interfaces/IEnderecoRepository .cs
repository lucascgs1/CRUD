using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        //IEnumerable<Endereco> GetAllEnderecosByUserId(int id);
    }
}
