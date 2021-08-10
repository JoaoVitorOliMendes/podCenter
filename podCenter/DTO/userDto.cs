using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace podCenter.DTO
{
    public class userDto
    {
        private int id;
        private String nome;
        private String email;
        private String senha;
        private String telefone;
        private String sexo;
        private int idade;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }

        public userDto(int id, string nome, string email, string senha, string telefone, string sexo, int idade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Telefone = telefone;
            this.Sexo = sexo;
            this.Idade = idade;
        }

        public userDto()
        {
        }
    }
}