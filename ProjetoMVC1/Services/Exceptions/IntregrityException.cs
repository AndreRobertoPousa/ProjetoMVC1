﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC1.Services.Exceptions
{
    public class IntegrityException : ApplicationException

    {    
        public IntegrityException(string message) : base(message)
        {

        }
    }

      
}
