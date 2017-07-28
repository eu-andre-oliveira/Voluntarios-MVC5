using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluntarios.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime? DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Docto_Cpf { get; set; }
        public int TipoProfissionalId { get; set; }
    }
}