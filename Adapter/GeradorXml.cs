using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class GeradorXml
    {
        public string GeraXml(object o)
        {
            XmlSerializer serializar = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializar.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
