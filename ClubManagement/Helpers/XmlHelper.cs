using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClubManagement.Helpers
{
    public class XmlFile
    {
        public string login { get; set; }
        public string pass { get; set; }
    }

    class XmlHelper
    {
        public static string fileConfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "conf_clubManagament.xml");


        public static void SaveLoginData(XmlFile xf)
        {
            TextWriter writer = new StreamWriter(fileConfPath);
            XmlSerializer ser = new XmlSerializer(typeof(XmlFile));
            ser.Serialize(writer, xf);
            writer.Close();
        }

        public static XmlFile ReadLoginData()
        {
            XmlSerializer ser = new XmlSerializer(typeof(XmlFile));
            XmlFile xf;

            using (XmlReader reader = XmlReader.Create(fileConfPath))
            {
                xf = (XmlFile)ser.Deserialize(reader);
            }
            return xf;
        }
    }
}
