using Projektet.Data;
using Projektet.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projektet.Data
{
    public class XMLWriter
    {
        public void WriteXML(CategoryList category)
        {
            var XML = new XmlSerializer(typeof(CategoryList));
            using (Stream writer = new FileStream("CategorieLister.xml", FileMode.Create))
            {
                XML.Serialize(writer, category);
            }
        }
    }
}
