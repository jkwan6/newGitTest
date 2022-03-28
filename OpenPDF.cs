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
    class OpenPDF
    {
        ///////////////////// INSTANCE VARIABLES //////////////////////////
        private string directoryName;
        public string DirectoryName
        {
            get
            {
                return directoryName;
            }
            set
            {
                directoryName = value;
            }
        }

        private string directoryPath;
        public string DirectoryPath
        {
            get
            {
                return directoryPath;
            }
            set
            {
                directoryPath = value;
            }
        }

        private string pdfFile;
        public string PDFFile
        {
            get
            {
                return pdfFile;
            }
            set
            {
                pdfFile = value;
            }
        }


        ///////////////////// CONSTRUCTORS /////////////////////////////////
        public OpenPDF()
        {
        }
        ////////////////////////////////////////////////////////////////////

        ///////////////////// PUBLIC METHODS ///////////////////////////////
        public PdfViewer getPDF()
        {
            PdfiumViewer.PdfViewer pdf = new PdfiumViewer.PdfViewer();
            pdf.Document = this.document(this.ofd());
            return pdf;
        }


        ///////////////////// PRIVATE METHODS //////////////////////////////
        private string ofd()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF files|*.pdf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    directoryName = ofd.FileName;
                }
            }
            return directoryName;
        }
        private PdfDocument document(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfiumViewer.PdfDocument pdfDocument = PdfiumViewer.PdfDocument.Load(stream);
            return pdfDocument;
        }
        ////////////////////////////////////////////////////////////////////


    }
}
