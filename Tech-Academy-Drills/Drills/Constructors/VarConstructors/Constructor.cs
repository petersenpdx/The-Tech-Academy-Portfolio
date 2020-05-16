using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarConstuctors
{
    class Constructor
    {
        private string first, last;
        

        public Constructor(string lastname, string firstname)
        {
            last = lastname;
            first = firstname;
        }
        public string lastname { get; set; }
        public string firstname { get; set; }
    }
}