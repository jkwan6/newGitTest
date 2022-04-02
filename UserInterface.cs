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
        private float initialWidth;
        public float InitialWidth { get { return initialWidth; } set { initialWidth = value; } }

        private float initialHeight;
        public float InitialHeight { get { return initialHeight; } set { initialHeight = value; } }   
        
        private PdfViewer viewer;

        public UserInterface()
        {
            InitializeComponent();
            ResizeRedraw = true;
            initialWidth = this.Size.Width;
            initialHeight = this.Size.Height;
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


        //protected virtual void OnSizeChanged()
        //{
        //    viewer.ClientSize = panel2.Size;
        //}


        public void Form1_SizeChanged(object sender, EventArgs e)
        {
            viewer.ClientSize = panel2.Size;
        }

        //public event EventHandler panel2sizechanged;
        //public void onsizechanged()
        //{
        //    if (panel2sizechanged != null)
        //        panel2sizechanged(this, EventArgs.Empty);
        //}

        private void AnaMenu_SizeChanged(object sender, EventArgs e)
        {


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

    }
}
