using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdf_reader_test
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        // Codes for clicking Button 1
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryChoice OpenDirectory1 = new DirectoryChoice();
            OpenDirectory1.ofd();
            string DirectoryPath = OpenDirectory1.DirectoryPath;
            webBrowser1.Navigate(DirectoryPath);
        }
    }
}
