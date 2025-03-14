using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Working_with_the_Adapter_pattern.Interfaces;

namespace Working_with_the_Adapter_pattern.Classes
{
    public class XmlToJsonAdapter : IJson
    {
        private readonly IXml _xml;

        public XmlToJsonAdapter(IXml xml)
        {
            _xml = xml;
        }

        public void GetJson()
        {
            _xml.GetXml();
            Console.WriteLine("Данные преобразованы в формат json.");
        }
    }
}
