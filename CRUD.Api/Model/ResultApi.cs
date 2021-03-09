using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Api.Model
{
    public class ResultApiDTO<T>
    {
        public T data { get; set; }
        public bool sucesso { get; set; }
        public string message { get; set; }
        public string error { get; set; }
    }
}
