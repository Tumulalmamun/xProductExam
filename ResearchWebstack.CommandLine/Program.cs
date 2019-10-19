using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using CommandLine;
using System.Net;
using ResearchWebstack.CommandLine.Options;


namespace QuickStart
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string ServiceUrl = "http://localhost:54033/XProductService.svc/Unittestresults/";
            WebRequest theRequest = WebRequest.Create(ServiceUrl);
            WebResponse theResponse = theRequest.GetResponse();

            DataContractSerializer collenctionData = new DataContractSerializer(typeof(ResearchWebstack.CommandLine.XProductService.UnitTest[]));
            var arrUnitTest = collenctionData.ReadObject(theResponse.GetResponseStream());
            var list = arrUnitTest as ResearchWebstack.CommandLine.XProductService.UnitTest[];
            Parser.Default.ParseArguments<ProgramOptions>(args)
                   .WithParsed<ProgramOptions>(o =>
                   {
                       if (o.Verbose)
                       {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                       }
                       //else
                       //{
                       //    Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                       //}
                       if (o.Python)
                       {
                           Process.Start("C:\\Program Files\\nodejs\\node.exe");
                       }
                       //else
                       //{
                       //    Console.WriteLine($"Current Arguments: -v {o.Python}");
                       //}
                       if(o.UnitTest)
                       {
                           Console.WriteLine("Bolck:");
                       }
                       else
                       {
                           Console.WriteLine($"Current Arguments: -v {o.ToString()}");
                       }
                   });
        }
    }
}