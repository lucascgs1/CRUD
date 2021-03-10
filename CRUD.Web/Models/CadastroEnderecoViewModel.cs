using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class CadastroEnderecoViewModel
    {
        public CadastroEnderecoViewModel(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string Titulo { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public bool EnderecoPrincipal { get; set; }
    }
}
