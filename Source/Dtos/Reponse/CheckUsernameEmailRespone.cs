﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Dtos.Reponse
{
    public class CheckUsernameEmailRespone
    {
        public bool IsUsernameExists { get; set; }
        public bool IsEmailExists { get; set; }
    }
}
