using Projektet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet.Logic
{
    public class Methods
    {
        public CategoryList catLibrary = new CategoryList();
        public XMLWriter xmlWriter = new XMLWriter();

        public void addCategory(string categoryName)
        {
            Category category = new Category(categoryName);
            catLibrary.Add(category);
            xmlWriter.WriteXML(catLibrary);
        }
    }
}
