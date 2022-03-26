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
        PdfViewer pdf;

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
            pdf = new PdfViewer();
            panel2.Controls.Add(pdf);
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }

        public void openfile( string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }
    }
}
