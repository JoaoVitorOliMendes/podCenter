using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace podCenter.DTO
{
    public class authoritiesDto
    {
        private String nome;
        private int userId;

        public string Nome { get => nome; set => nome = value; }
        public int UserId { get => userId; set => userId = value; }

        public authoritiesDto(string nome, int userId)
        {
            Nome = nome;
            UserId = userId;
        }

        public authoritiesDto()
        {
        }
    }
}