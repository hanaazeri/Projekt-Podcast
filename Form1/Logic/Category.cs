using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projektet.Logic
{
    public class Category
    {
        public List<Podcast> episodes { get; set; }
        public string CategoryName;

       public Category(string catName)
       {
            CategoryName = catName;
       }
    }
}
