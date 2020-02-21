using System;

namespace SlackExchange.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string PhotoUrl { get; set; }
    }
}