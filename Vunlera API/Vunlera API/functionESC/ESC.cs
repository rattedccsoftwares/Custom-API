using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.imports;

namespace API.functionESC
{
    internal class ESC
    {
        public static void ESCexec(string SC)
        {
            dllimports.ExecuteSC(Encoding.UTF8.GetBytes(SC));
        }
    }
}
