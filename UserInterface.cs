using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfiumViewer;
using System.IO;    

namespace pdf_reader_test
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            ResizeRedraw = true;
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
            OpenPDF pdf = new OpenPDF();
            PdfViewer pdfViewer = new PdfViewer();
            pdfViewer = pdf.getPDF();
            pdfViewer.ClientSize = panel2.Size;
            panel2.Controls.Add(pdfViewer);



        }



        public event EventHandler panel2sizechanged;
        public void onsizechanged()
        {
            if (panel2sizechanged != null)
                panel2sizechanged(this, EventArgs.Empty);
        }


    }
}
