using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model
{
    public class HashWithSalt
    {
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
