using Projektet.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Projektet
{
    public partial class tb : Form
    {
        public tb()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbkategori_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nyurl_Click(object sender, EventArgs e)
        {
          
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Nykategori_Click(object sender, EventArgs e)
        {
          
        }

        public void tbkategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sparakategori_Click(object sender, EventArgs e)
        {
            var categoryName = tbkategori.Text;
            CategoryList.addCategory(categoryName);
        }
    }
}
