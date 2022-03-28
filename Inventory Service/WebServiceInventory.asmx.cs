using Inventory.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace InventoryWebApplication
{
    /// <summary>
    /// Summary description for WebServiceInventory
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceInventory : System.Web.Services.WebService, IInventoryService
    {

        //[return: XmlElement("ackCode", Namespace = "sms.schema.inventory")]
        public string addItem(string ItemDocument)
        {
            string ackCode = "Item added. ACK Code: ACK-" + ItemDocument.ToString();
            return ackCode;//throw new NotImplementedException();
        }

        //[return: XmlElement("ItemDocument", Namespace = "sms.schema.inventory")]
        public string getItem(int uniqueItemId)
        {
            string item = "Item returned, ItemID: " + uniqueItemId.ToString();
            return item;//throw new NotImplementedException();
        }

        //[return: XmlElement("stockLevelValue", Namespace = "sms.schema.inventory")]
        public int getItemCount(int uniqueItemId)
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 2000);
            return count;
            //throw new NotImplementedException();
        }

        /*[WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }*/

        //[return: XmlElement("ackCode", Namespace = "sms.schema.inventory")]
        public string removeItem(int uniqueItemId)
        {
            string ackCode = "Item removed. ACK Code: ACK-" + uniqueItemId.ToString();
            return ackCode;//throw new NotImplementedException();
        }
    }
}
