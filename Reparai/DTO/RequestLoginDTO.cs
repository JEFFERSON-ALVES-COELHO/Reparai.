using System;
using System.Collections.Generic;
using System.Text;

namespace Reparai.DTO
{
    public class RequestLoginDTO
    {
        public required string Email { get; set; }
        public required string Senha { get; set; }

    }
}


