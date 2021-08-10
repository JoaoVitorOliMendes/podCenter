using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace podCenter.DTO
{
    public class podcastDto
    {
        private int id;
        private String nome;
        private int podcasterId;

        public podcastDto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int PodcasterId { get => podcasterId; set => podcasterId = value; }

        public podcastDto(int id, string nome, int podcasterId)
        {
            Id = id;
            Nome = nome;
            PodcasterId = podcasterId;
        }
    }
}