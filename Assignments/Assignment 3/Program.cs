using System;
using System.Xml;
class Program {

    static void Main(string[] args)
    {
        XmlWriterSettings settings = new XmlWriterSettings(); settings.Indent = true;
        settings.IndentChars = "\t";
        XmlWriter w = XmlWriter.Create("GPS.xml", settings); w.WriteStartDocument();
        w.WriteStartElement("GPS_Log");
        w.WriteStartElement("Position"); w.WriteAttributeString("DateTime", DateTime.Now.ToString()); w.WriteElementString("x", "65.8973342");
        w.WriteElementString("y", "72.3452346"); w.WriteStartElement("SatteliteInfo"); w.WriteElementString("Speed", "40");
        w.WriteElementString("NoSatt", "7"); w.WriteEndElement();//End element of Satteliteinfo
        w.WriteEndElement(); //End element of Position


        w.WriteStartElement("Image"); w.WriteAttributeString("Resolution", "1024x800"); w.WriteElementString("Path", @"\images\1.jpg");
        w.WriteEndDocument(); w.Close();
    }
        }