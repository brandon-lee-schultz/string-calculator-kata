﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator_Kata.Exceptions
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }
}
