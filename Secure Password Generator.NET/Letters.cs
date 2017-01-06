using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    class Letters
    {
        public bool include = false;
        public bool upper = false;
        public bool lower = false;

        public Letters(bool include, bool upper, bool lower)
        {
            this.include = include;
            this.upper = upper;
            this.lower = lower;
        }
    }
}
