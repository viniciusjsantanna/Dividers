using System;
using System.Collections.Generic;
using System.Text;

namespace Dividers.Application.DTO.Dividers
{
    public class NumbersDTO
    {
        public IList<int> Primes { get; set; }
        public IList<int> Dividers { get; set; }
    }
}
