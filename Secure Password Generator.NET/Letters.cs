using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    class Letters
    {
        public bool include;
        public bool upper;
        public bool lower;

        public Letters(bool include, bool upper, bool lower)
        {
            this.include = include;
            this.upper = upper;
            this.lower = lower;
        }
    }
}
