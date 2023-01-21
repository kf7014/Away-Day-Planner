using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class PdfDisplayPresenter
    {
        private readonly IEventModel EventModel;
        private readonly IPdfDisplayView pdfDisplayView;



        public PdfDisplayPresenter(IPdfDisplayView pdfDisplayView, IEventModel eventModel)
        {
            this.pdfDisplayView = pdfDisplayView;
            this.EventModel = EventModel;
            pdfDisplayView.register(this);
        }

        

        public void GeneratePDFClick()
        {
            GeneratePDF();
        }
        public void GeneratePDF()
        {
            String filePath = AppDomain.CurrentDomain.BaseDirectory + "Invoice.pdf";
            String companyName = "Test company";
            using (FileStream stream = new FileStream("invoice.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("Invoice for " + companyName));
                pdfDoc.Close();
            }
            pdfDisplayView.ShowInvoice(filePath);
        }
    }
}
