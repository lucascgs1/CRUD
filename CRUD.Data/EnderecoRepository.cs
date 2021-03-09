using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CRUD.Data.Interfaces;
using CRUD.Model;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CRUD.Data
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private readonly ApplicationDbContext _context;

        public EnderecoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        //public IEnumerable<Endereco> GetAllEnderecosByUserId(int id)
        //{
        //    return Db.Endereco.Where(e => e.UsuarioId == id).ToList();
        //}
    }
}