using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Model
{
    public class Cliente
    {
        public long Id { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
