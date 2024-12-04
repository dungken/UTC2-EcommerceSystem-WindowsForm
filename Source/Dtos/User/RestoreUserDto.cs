using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Dtos.User
{
    public class RestoreUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}