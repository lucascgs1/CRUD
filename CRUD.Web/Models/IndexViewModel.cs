using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Web.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.LstUsuario = new List<Usuario>();
        }

        public IList<Usuario> LstUsuario { get; set; }
    }
}
