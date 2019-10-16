using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ResearchWebstack.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IXProductService
    {
        [OperationContract]
        [WebGet(UriTemplate = "", ResponseFormat = WebMessageFormat.Xml)]
        UnitTest[] GetAllTests();

        [OperationContract]
        [WebGet(UriTemplate = "/GetFailTests", ResponseFormat = WebMessageFormat.Xml)]
        UnitTest[] GetFailTests();

    }
    [DataContract]
    public class UnitTest
    {
        [DataMember]
        public string TaskName { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string Namespace { get; set; }
        [DataMember]
        public string FullyQuantiedName { get; set; }
        [DataMember]
        public string Status { get; set; }
    }

}
