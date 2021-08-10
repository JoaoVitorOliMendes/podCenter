using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace podCenter.DTO
{
    public class playlistDto
    {
        private int id;
        private String nome;
        private String podcastId;
        private int userId;

        public playlistDto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string PodcastId { get => podcastId; set => podcastId = value; }
        public int UserId { get => userId; set => userId = value; }

        public playlistDto(int id, string nome, string podcastId, int userId)
        {
            Id = id;
            Nome = nome;
            PodcastId = podcastId;
            UserId = userId;
        }
    }
}