using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Dtos.Account
{
    public class VerifyCodeDto
    {
        [Required]
        public string Code { get; set; }
    }
}