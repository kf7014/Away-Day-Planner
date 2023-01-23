/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Presenters
{
    public class PdfDisplayPresenter
    {
        private static PdfDisplayPresenter _instance;
        private readonly IEventModel EventModel;
        private readonly IClientModel ClientModel;
        private readonly IPdfDisplayView pdfDisplayView;

        private PdfDisplayPresenter(IPdfDisplayView pdfDisplayView, IEventModel eventModel, IClientModel clientModel)
        {
            this.pdfDisplayView = pdfDisplayView;
            this.EventModel = eventModel;
            this.ClientModel = clientModel;
            pdfDisplayView.register(this);
        }

        public static PdfDisplayPresenter Instance(IPdfDisplayView pdfDisplayView, IEventModel eventModel, IClientModel clientModel)
        {
            if (_instance == null)
            {
                _instance = new PdfDisplayPresenter(pdfDisplayView, eventModel, clientModel);
            }
            return _instance;
        }

        public void GeneratePDFClick()
        {
            GeneratePDF();
        }
        public void GeneratePDF()
        {

            int clientID = EventModel.clientId + 1;
            int eventID = EventModel.getCurrentEventId();
            String filePath = AppDomain.CurrentDomain.BaseDirectory + "Invoice.pdf";
            Client client = ClientModel.getClient(clientID);
            String companyName = client.name;
            IActivity[] activityList = EventModel.getAllActivities();

            Event[] events = EventModel.getAllEvents();
            Event currentEvent = events[0];
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i].id == eventID)
                {
                    currentEvent = events[i];
                }

            }
            using (FileStream stream = new FileStream("invoice.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("Invoice for " + companyName));
                pdfDoc.Add(new Paragraph("The number of attendees you have requested for this event is: " + currentEvent.noOfAttendees));
                pdfDoc.Add(new Paragraph("Activitys selected        :        Price(£)"));
                for (int i = 0; i < activityList.Length; i++)
                {
                    IActivity currentActivity = activityList[i];
                    if (currentActivity.EventFK == eventID)
                    {
                        pdfDoc.Add(new Paragraph(currentActivity.name + "       :       " + currentActivity.price));

                    }

                }
                pdfDoc.Add(new Paragraph("The base cost of this package is: " + currentEvent.price));
                pdfDoc.Add(new Paragraph("Plus our service charge of 50%: " + (currentEvent.price * (decimal)0.5)));
                pdfDoc.Add(new Paragraph("For a total package cost of: " + (currentEvent.price * (decimal)1.5)));
                pdfDoc.Add(new Paragraph("As a reminder this is only an initial estimate and nothing is booked \nuntil we recive full conformation from you,\ncontact one of our agents to finalise your booking"));
                pdfDoc.Close();
            }
            pdfDisplayView.ShowInvoice(filePath);
        }
    }
}

