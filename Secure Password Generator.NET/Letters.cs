using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    class Letters
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

        public bool getInclude(){
            return include;
        }

        public bool getUpper()
        {
            return upper;
        }

        public bool getLower()
        {
            return lower;
        }


    }
}
