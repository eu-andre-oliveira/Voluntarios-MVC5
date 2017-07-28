﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluntarios.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}