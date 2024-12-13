using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace API.imports
{
    internal class dllimports
    {
        [DllImport("bin\\VulneraInjector.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void StartClient();

        [DllImport("bin\\VulneraInjector.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void ExecuteSC(byte[] scriptSource);
    }
}
