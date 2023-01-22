﻿using System;
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
        private readonly IEventModel EventModel;
        private readonly IClientModel ClientModel;
        private readonly IPdfDisplayView pdfDisplayView;



        public PdfDisplayPresenter(IPdfDisplayView pdfDisplayView, IEventModel eventModel, IClientModel clientModel)
        {
            this.pdfDisplayView = pdfDisplayView;
            this.EventModel = eventModel;
            this.ClientModel = clientModel;
            pdfDisplayView.register(this);
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
                pdfDoc.Add(new Paragraph("Activitys selected : Price(£)"));
                for (int i = 0; i < activityList.Length; i++)
                {
                    IActivity currentActivity = activityList[i];
                    if (currentActivity.EventFK == eventID)
                    {
                        pdfDoc.Add(new Paragraph(currentActivity.name + "              " + currentActivity.price));
                    }

            }

                pdfDoc.Add(new Paragraph("The base cost of this package is: " + currentEvent.price));
                pdfDoc.Add(new Paragraph("Plus our service charge of 50%: " +(currentEvent.price*(decimal)0.5)));
                pdfDoc.Add(new Paragraph("For a total package cost of: " + (currentEvent.price * (decimal)1.5)));
                pdfDoc.Close();
            }
        pdfDisplayView.ShowInvoice(filePath);
        }
    }
}

