using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projektet.Logic
{
    public class CategoryList
    {
        public List<Category> catList { get; set; }
        public XmlWriter xmlWriter;


        public void addCategory(string categoryName)
        {
            Category category = new Category(categoryName);
            catList.Add(category);
        }

    }
}
