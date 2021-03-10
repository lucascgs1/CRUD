using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class CadastroEnderecoViewModel
    {
        public CadastroEnderecoViewModel()
        {
        }

        public CadastroEnderecoViewModel(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Id do Usuario")]
        public int UsuarioId { get; set; }

        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "O titulo é obrigatório", AllowEmptyStrings = false)]
        public string Titulo { get; set; }

        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "O logradouro é obrigatório", AllowEmptyStrings = false)]
        public string Logradouro { get; set; }

        [Display(Name = "Numero")]
        [Required(ErrorMessage = "O numero é obrigatório", AllowEmptyStrings = false)]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O bairro é obrigatório", AllowEmptyStrings = false)]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O cidade é obrigatório", AllowEmptyStrings = false)]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O estado é obrigatório", AllowEmptyStrings = false)]
        public string Estado { get; set; }

        [Display(Name = "Endereço Principal")]
        public bool EnderecoPrincipal { get; set; }
    }
}
