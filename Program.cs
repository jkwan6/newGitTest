using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfiumViewer;


namespace pdf_reader_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserInterface userInterface = new UserInterface();
            userInterface.Resize += userInterface.Form1_SizeChanged;
            Application.Run(userInterface);

        }
        /// Main Method END
    




    }
}
