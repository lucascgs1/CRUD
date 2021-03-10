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
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Cliente GetById(long id)
        {
            return DbSet.Find(id);
        }

        public void Remove(long id)
        {
            DbSet.Remove(DbSet.Find(id));
        }


        public void Save(Cliente cliente)
        {
            if (cliente.Id > 0)
            {
                DbSet.Update(cliente);
            }
            else
                DbSet.Add(cliente);

            Db.SaveChanges();
        }
    }
}