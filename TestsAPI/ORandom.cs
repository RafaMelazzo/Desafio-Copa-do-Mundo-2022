using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAPI
{
    public class ORandom
    {
        public ORandom()
        {
            return (new Random().Next(1, 20));
        }
    }
}
