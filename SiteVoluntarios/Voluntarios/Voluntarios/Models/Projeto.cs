using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluntarios.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Endereco> Enderecos { get; set; }
    }
}