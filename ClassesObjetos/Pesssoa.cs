﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Pesssoa
    {
        //Atributos | Campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome);
        }
    }
}
