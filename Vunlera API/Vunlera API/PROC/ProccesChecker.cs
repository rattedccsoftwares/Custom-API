using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.PROC
{
    internal class ProccesChecker
    {
        public static bool IsRobloxOpen() => Process.GetProcessesByName("RobloxPlayerBeta").Length != 0;
    }
}
