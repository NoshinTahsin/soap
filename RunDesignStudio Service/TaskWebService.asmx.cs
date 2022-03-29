using RunDesignStudio.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace RunDesignStudioWebApplication
{
    /// <summary>
    /// Summary description for TaskWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TaskWebService : System.Web.Services.WebService, IRunDesignStudioService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //[return: XmlElement("ackCode", Namespace = "sms.schema.runDesignStudio")]
        public string Start(int architectId, string dateValue)
        {
            localhost.WebServiceDesigns designs = new localhost.WebServiceDesigns();
            string ackCode = designs.addBase("doc-123", 222);
            return ackCode;//throw new NotImplementedException();
        }
    }
}
