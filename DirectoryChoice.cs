using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfiumViewer;

namespace pdf_reader_test
{
    class DirectoryChoice
    {
        // Instance Variables
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

        private string directoryType;
        public string DirectoryType
        {
            get
            {
                return directoryType;
            }
            set
            {
                directoryType = value;
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

        // Constructors
        public DirectoryChoice()
        {
        }

        public void ofd()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF files|*.pdf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    directoryPath = ofd.FileName;
                }
            }
        }

    }
}
