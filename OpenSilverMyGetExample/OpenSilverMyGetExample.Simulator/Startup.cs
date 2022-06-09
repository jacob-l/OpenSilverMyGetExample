using OpenSilver.Simulator;
using System;

namespace OpenSilverMyGetExample.Simulator
{
    static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
