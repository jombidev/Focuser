using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Focuser.Dto
{
    public class ProcessInfo
    {
        public string Title { get; private set; }
        public string DisplayName => $"{Title} ({Pid} {ProcessName})";
        public string ProcessName { get; private set; }
        public int Pid { get; private set; }

        public ProcessInfo(string title, string processName, int pid)
        {
            Title = title;
            ProcessName = processName;
            Pid = pid;
        }
    }
}
