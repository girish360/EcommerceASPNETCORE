﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Usuario
    {
        //Atributos genericos para todos os Usuarios
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Senha { get; private set; }

        /*********************************************/


        public Usuario(int id,string nome,string email,string cpf,string senha)
            : this(nome,email,cpf,senha)
        {
            this.Id = id;
        }

        public Usuario(string nome,string email,string cpf,string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
            this.Senha = senha;
        }
        public Usuario() { }
        

    }
}
