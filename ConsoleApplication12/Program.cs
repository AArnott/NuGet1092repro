using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Threading;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Requires.NotNull(args, nameof(args));
            JoinableTaskFactory jtf;
        }
    }
}
