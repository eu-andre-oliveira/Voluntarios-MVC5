﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voluntarios.Infra;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();

            Console.ReadKey();
        }
    }
}
