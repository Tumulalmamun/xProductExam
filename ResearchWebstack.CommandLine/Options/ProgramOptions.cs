using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ResearchWebstack.CommandLine.Options
{
   
    public class ProgramOptions
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('p', "runPython", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Python { get; set; }


        [Option('u', "getUnitTest", Required = false, HelpText = "Set output to verbose messages.")]
        public bool UnitTest { get; set; }

    }
}
