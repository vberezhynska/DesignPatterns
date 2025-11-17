using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IStrategy
    {
        public decimal Execute(decimal x, decimal y);
    }
}
