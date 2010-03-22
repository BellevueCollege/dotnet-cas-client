﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.SoapEnvelope
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
    [XmlRoot(Namespace="http://schemas.xmlsoap.org/soap/envelope/", IsNullable=false)]
    public class Fault {
        [XmlElement("faultcode", Form = XmlSchemaForm.Unqualified)]
        public XmlQualifiedName FaultCode
        {
            get;
            set;
        }

        [XmlElement("faultstring", Form = XmlSchemaForm.Unqualified)]
        public string FaultString
        {
            get;
            set;
        }

        [XmlElement("faultactor", Form = XmlSchemaForm.Unqualified, DataType = "anyURI")]
        public string FaultActor
        {
            get;
            set;
        }

        [XmlElement("detail", Form = XmlSchemaForm.Unqualified)]
        public Detail Detail
        {
            get;
            set;
        }
    }
}

