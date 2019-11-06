using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Containervervoer
{
    class Container
    {
        public enum category
        {
            valuable,
            cooled,
            standard
        }

        public category Categories { get; set; }
        public int Weight { get; set; }
    }
}
