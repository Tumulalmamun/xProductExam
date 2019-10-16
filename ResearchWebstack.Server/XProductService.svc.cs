using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ResearchWebstack.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class XProductService : IXProductService
    {

        List<UnitTest> listUnitTest = new List<UnitTest>();

        public UnitTest[] GetAllTests()
        {
            return new UnitTest[]
            {
                  new UnitTest() { TaskName = "101",ClassName = "mamun",Namespace = "CTD",FullyQuantiedName = "",Status = ""},
                  new UnitTest() { TaskName = "101",ClassName = "mamun",Namespace = "CTD",FullyQuantiedName = "",Status = "F"},
                  new UnitTest() { TaskName = "101",ClassName = "mamun",Namespace = "CTD",FullyQuantiedName = "",Status = "F"}


            };
        }

        public UnitTest[] GetFailTests()
        {
            return new UnitTest[]
            {

                new UnitTest() { TaskName = "101",ClassName = "mamun",Namespace = "CTD",FullyQuantiedName="",Status ="F"},
                new UnitTest() {TaskName = "101",ClassName = "mamun",Namespace = "CTD",FullyQuantiedName="",Status ="F"}
            };
        }
    }
}