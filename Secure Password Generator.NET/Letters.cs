using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    struct Letters
    {
        public Letters(bool include, bool upper, bool lower)
        {
            Include = include;
            Upper = upper;
            Lower = lower;
        }

        public bool Include
        {
            set;
            get;
        }

        public bool Upper
        {
            set;
            get;
        }

        public bool Lower
        {
            set;
            get;
        }

    }
}
