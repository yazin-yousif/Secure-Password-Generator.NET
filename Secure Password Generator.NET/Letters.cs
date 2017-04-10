using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    struct Letters
    {
        private bool include;
        private bool upper;
        private bool lower;

        public Letters(bool include, bool upper, bool lower)
        {
            this.include = include;
            this.upper = upper;
            this.lower = lower;
        }

        public bool doInclude(){
            return include;
        }

        public bool setUpper()
        {
            return upper;
        }

        public bool setLower()
        {
            return lower;
        }


    }
}
