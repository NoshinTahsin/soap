using Materials.Contract.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace MaterialsWebApplication
{
    /// <summary>
    /// Summary description for WebServiceMaterials
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMaterials : System.Web.Services.WebService, IMaterialsService
    {
        //[return: XmlElement("developedMaterialDoc", Namespace = "sms.schema.materials")]
        public string getDeveloped(int uniqueMaterialId, int architectId)
        {
            string developedMaterialDoc = "Returned Developed Material Document for Material: MAT"+ uniqueMaterialId.ToString()+", developed by: ARC"+architectId.ToString();
            return developedMaterialDoc;
            //throw new NotImplementedException();
        }

        //[return: XmlElement("purchasedMaterialDoc", Namespace = "sms.schema.materials")]
        public string getPurchased(int uniqueMaterialId)
        {
            string purchasedMaterialDoc = "Returned Purchased Material Document for Material: MAT" + uniqueMaterialId.ToString();
            return purchasedMaterialDoc; 
            //throw new NotImplementedException();
        }

        /*[WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }*/

        //[return: XmlElement("stockLevelValue", Namespace = "sms.schema.materials")]
        public string reportStockLevels(int uniqueMaterialId)
        {
            Random rnd = new Random();
            int stockLevel = rnd.Next(1,2000);
            string stockLevelValue = "Stock Level Values for Material MAT" + uniqueMaterialId.ToString()+": "+ stockLevel+" units";
            return stockLevelValue;
            //throw new NotImplementedException();
        }
    }
}
