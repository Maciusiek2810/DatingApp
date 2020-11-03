using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForUpdateDto
    {
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime LastActive { get; set; }
        // public string Username { get; set; }
        // public string Introduction { get; set; }
        // public string LookingFor { get; set; }
        // public string Interests { get; set; }
        // public string Country { get; set; }
        public UserForUpdateDto()
        {
            LastActive = DateTime.Now;
        }

    }
}