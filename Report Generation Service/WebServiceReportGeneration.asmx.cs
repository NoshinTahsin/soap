using ReportGeneration.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace ReportGenerationWebApplication
{
    /// <summary>
    /// Summary description for WebServiceReportGeneration
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceReportGeneration : System.Web.Services.WebService, IGenerateReportService
    {
        //[return: XmlElement("eventReport", Namespace = "sms.schema.reportGeneration")]
        [WebMethod]
        public string generateReport(int uniqueEventId)
        {
            string eventReport = "Event Report for Event-" + uniqueEventId.ToString()+", generated at: "+ DateTime.Now.ToString("MM/dd/yy H:mm:ss zzz");
            return eventReport;//throw new NotImplementedException();//throw new NotImplementedException();
        }

        /*
        public string HelloWorld()
        {
            return "Hello World";
        }*/
    }
}
