using Designs.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace DesignsWebApplication
{
    /// <summary>
    /// Summary description for WebServiceDesigns
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDesigns : System.Web.Services.WebService, IDesignsService
    {
        //[return: XmlElement("ackCode", Namespace = "sms.schema.designs")]
        public string addBase(string designDoc, int architectId)
        {
            string ackCode = "Added base design. ACKNOWLEDGEMENT CODE: " + designDoc + "-" + architectId.ToString();
            return ackCode;//throw new NotImplementedException();
        }

        //[return: XmlElement("designDoc", Namespace = "sms.schema.designs")]
        public string getDocument(int uniqueDesignId, int architectId)
        {
            string designDocument = "Returning Design Document for Design-" + uniqueDesignId.ToString() + "-" + architectId.ToString();
            return designDocument;///throw new NotImplementedException();
        }

        /*[WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }*/

        //[return: XmlElement("simulationReportDoc", Namespace = "sms.schema.designs")]
        public string simulate(int uniqueMaterialId, int uniqueDesignId, int architectId)
        {
            string simulationReportDocument = "Returning Simulation Report Document for Design-" + uniqueMaterialId.ToString() + "-" + uniqueDesignId.ToString() + "-" + architectId.ToString();
            return simulationReportDocument;//throw new NotImplementedException();
        }
    }
}
