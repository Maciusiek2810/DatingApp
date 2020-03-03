using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl {get;set;}
        public string Email { get; set; }
        // public string PhoneNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public ICollection<Photo> Photos { get; set; }
        // public string Gender { get; set; }
        // public string KnownAs { get; set; }
        // public string City { get; set; }
        // public string Country { get; set; }
        // public int Age { get; set; }
    }
}