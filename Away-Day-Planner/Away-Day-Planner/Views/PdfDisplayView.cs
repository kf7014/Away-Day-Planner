/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public partial class PdfDisplayView : Form, IPdfDisplayView
    {
        private PdfDisplayPresenter PdfDisplayPresenter;
        public PdfDisplayView()
        {
            InitializeComponent();
        }
        public void register(PdfDisplayPresenter pdfDisplayPresenter)
        {
            this.PdfDisplayPresenter = pdfDisplayPresenter;
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void GenerateInvoice_Click(object sender, EventArgs e)
        {
            PdfDisplayPresenter.GeneratePDF();
            GenerateInvoice.Visible = false;
        }
        public void ShowInvoice(string filePath)
        {
            webBrowser2.Navigate(filePath);
        }
    }
}
