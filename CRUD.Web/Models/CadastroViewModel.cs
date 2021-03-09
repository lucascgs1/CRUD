using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class CadastroViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "O email é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O telefone é obrigatório", AllowEmptyStrings = false)]
        public string Telefone { get; set; }
    }
}
