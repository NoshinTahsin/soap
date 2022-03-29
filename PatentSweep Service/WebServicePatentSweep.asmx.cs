using PatentSweep.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace PatentSweepWebApplication
{
    /// <summary>
    /// Summary description for WebServicePatentSweep
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePatentSweep : System.Web.Services.WebService, IPatentSweepService
    {

        [WebMethod]
        /*public string HelloWorld()
        {
            return "Hello World";
        }*/

        //[return: XmlElement("patentStatusReport", Namespace = "sms.schema.patentSweep")]
        public string performPatentSweep(int uniqueDesignId)
        {
            string patentStatusReport = "No patent found for Design-" + uniqueDesignId.ToString() +", Patent Sweep Performed at: "+ DateTime.Now.ToString("MM/dd/yy H:mm:ss zzz");
            return patentStatusReport; //throw new NotImplementedException();
        }
    }
}
