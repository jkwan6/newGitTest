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
        private PdfViewer viewer;

        public UserInterface()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenPDF pdf = new OpenPDF();
            PdfViewer pdfViewer = new PdfViewer();
            pdfViewer = pdf.getPDF();
            pdfViewer.ClientSize = panel2.Size;
            panel2.Controls.Add(pdfViewer);
            viewer = pdfViewer;
           



        }

        public void Form1_SizeChanged(object sender, EventArgs e)
        {
            viewer.ClientSize = panel2.Size;
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenPDF pdf = new OpenPDF();
            PdfViewer pdfViewer = new PdfViewer();
            pdfViewer = pdf.getPDF();

            var image1 = pdfViewer.Document.Render(1, 300, 300, PdfRenderFlags.CorrectFromDpi);

            image1.Save(@"C:\Users\User\Pictures\picture1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            


        }
    }
}
