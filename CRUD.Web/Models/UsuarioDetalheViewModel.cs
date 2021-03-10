using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class UsuarioDetalheViewModel : CadastroUsuarioViewModel
    {
        public UsuarioDetalheViewModel()
        {
            this.LstEndereco = new List<Endereco>();
        }

        /// <summary>
        /// lista de enderecos
        /// </summary>
        public IList<Endereco> LstEndereco { get; set; }
    }
}
