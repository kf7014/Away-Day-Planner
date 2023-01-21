using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class pdfDisplayPresenter
    {
        private IpdfDisplayView pdfDisplayView;
        private IEventModel EventModel;

        public pdfDisplayPresenter(IpdfDisplayView pdfDisplayView, IEventModel EventModel)
        {
            this.pdfDisplayView = pdfDisplayView;
            this.EventModel = EventModel;
            pdfDisplayView.register(this);
        }
        public void OnGenerateInvoiceClick(object sender, EventArgs e)
        {
            UpdateView();
        }
        public void UpdateView()
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
        }
    }
}
