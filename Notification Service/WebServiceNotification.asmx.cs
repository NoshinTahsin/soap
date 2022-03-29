using Notification.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace NotificationWebApplication
{
    /// <summary>
    /// Summary description for WebServiceNotification
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceNotification : System.Web.Services.WebService, INotificationService
    {
        //[return: XmlElement("eventNotification", Namespace = "sms.schema.notification")]
        [WebMethod]
        public string generateNotification(int uniqueEventId)
        {
            string notification = "Notification generated for event: EVENT-" + uniqueEventId.ToString();
            return notification; //throw new NotImplementedException();
        }

        /*[WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }*/
    }
}
