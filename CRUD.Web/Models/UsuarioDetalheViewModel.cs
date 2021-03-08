using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class UsuarioDetalheViewModel
    {
        public UsuarioDetalheViewModel()
        {
            this.LstEndereco = new List<Endereco>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public IList<Endereco> LstEndereco { get; set; }
    }
}
