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
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Usuario GetUsuarioById(int id)
        {
            return DbSet.AsNoTracking().Include(e => e.Enderecos).FirstOrDefault(x => x.Id == id);
        }

        public void Save(Usuario usuario)
        {
            if (usuario.Id > 0)
            {
                DbSet.Update(usuario);
            }
            else
                DbSet.Add(usuario);

            Db.SaveChanges();
        }
    }
}