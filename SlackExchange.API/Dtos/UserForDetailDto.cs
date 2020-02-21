using System;
using System.Collections.Generic;
using SlackExchange.API.Models;

namespace SlackExchange.API.Dtos
{
    public class UserForDetailDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Name { get; set; }
        public string ShortBio { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailDto> Photos { get; set; }
    }
}