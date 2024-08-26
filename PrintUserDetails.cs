using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public delegate void Details();
    internal class PrintUserDetails
    {
        public void Print(Details obj)
        {           
            obj();
        }
    }
}
