﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 
namespace Materials.Contract.First {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Web.Services.WebServiceBindingAttribute(Name="materialsService", Namespace="sms.schema.materials")]
    public interface IMaterialsService {
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44361/materialsservice.asmx?op=getDeveloped", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("developedMaterialDoc", Namespace="sms.schema.materials")]
        string getDeveloped([System.Xml.Serialization.XmlElementAttribute(Namespace="sms.schema.materials")] int uniqueMaterialId, [System.Xml.Serialization.XmlElementAttribute(Namespace="sms.schema.materials")] int architectId);
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44361/materialsservice.asmx?op=getPurchased", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("purchasedMaterialDoc", Namespace="sms.schema.materials")]
        string getPurchased([System.Xml.Serialization.XmlElementAttribute(Namespace="sms.schema.materials")] int uniqueMaterialId);
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44361/materialsservice.asmx?op=reportStockLevels", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("stockLevelValue", Namespace="sms.schema.materials")]
        string reportStockLevels([System.Xml.Serialization.XmlElementAttribute(Namespace="sms.schema.materials")] int uniqueMaterialId);
    }
}
