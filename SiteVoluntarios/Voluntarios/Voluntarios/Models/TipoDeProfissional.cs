using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluntarios.Models
{
    public class TipoDeProfissional
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public bool NecessitaCertificacao { get; set; }

    }
}