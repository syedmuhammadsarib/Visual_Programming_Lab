using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        XmlWriterSettings settings = new XmlWriterSettings { Indent = true, IndentChars = "\t" };
        using (XmlWriter w = XmlWriter.Create("GPS.xml", settings))
        {
            w.WriteStartDocument();
            w.WriteStartElement("GPS_Log");

            w.WriteStartElement("Position");
            w.WriteAttributeString("DateTime", DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt"));
            w.WriteElementString("x", "65.8973342");
            w.WriteElementString("y", "72.3452346");
            w.WriteStartElement("SatteliteInfo");
            w.WriteElementString("Speed", "40");
            w.WriteElementString("NoSatt", "7");
            w.WriteEndElement();
            w.WriteEndElement();

            w.WriteStartElement("Image");
            w.WriteAttributeString("Resolution", "1024x800");
            w.WriteElementString("Path", @"\images\1.jpg");
            w.WriteEndElement();

            w.WriteEndElement();
            w.WriteEndDocument();
        }

        Console.WriteLine("XML file 'GPS.xml' has been created successfully.\n");
        Console.WriteLine("Reading XML file 'GPS.xml':\n");

        int indentation = 0;
        using (XmlReader reader = XmlReader.Create("GPS.xml"))
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write(new string('\t', indentation) + "<" + reader.Name);
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                Console.Write($" {reader.Name}=\"{reader.Value}\"");
                            }
                            reader.MoveToElement();
                        }
                        Console.WriteLine(">");
                        indentation++;
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(new string('\t', indentation) + reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        indentation--;
                        Console.WriteLine(new string('\t', indentation) + "</" + reader.Name + ">");
                        break;
                }
            }
        }
        Console.WriteLine("\nXML file reading completed.");
    }
}
