using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public partial class pdfDisplayView : Form, IpdfDisplayView
    {
        private pdfDisplayPresenter pdfDisplayPresenter;
        public pdfDisplayView()
        {
            InitializeComponent();
        }
        public void register(pdfDisplayPresenter pdfDisplayPresenter)
        {
            this.pdfDisplayPresenter = pdfDisplayPresenter;

        }

        private void generatePDF_Click(object sender, EventArgs e)
        {
            {
                
                string path = AppDomain.CurrentDomain.BaseDirectory + "Invoice.pdf";
                string clientName = "NAME HOLDER";
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("Initial cost Estimate for: " + clientName));
                doc.Add(new Paragraph("Activitys chosen : Cost"));
                
                doc.Add(new Paragraph());
                doc.Close();
                webBrowser1.Navigate(path);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
