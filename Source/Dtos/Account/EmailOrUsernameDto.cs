using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Dtos.Account
{
    public class EmailOrUsernameDto
    {
        [Required]
        public string EmailOrUsername { get; set; }
    }
}