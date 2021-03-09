using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class UsuarioDetalheViewModel : CadastroViewModel
    {
        public UsuarioDetalheViewModel()
        {
            this.LstEndereco = new List<Endereco>();
        }

        public CadastroEnderecoViewModel Endereco { get; set; }

        public IList<Endereco> LstEndereco { get; set; }
    }
}
