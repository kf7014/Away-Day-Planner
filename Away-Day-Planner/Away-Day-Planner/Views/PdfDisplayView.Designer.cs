
namespace Away_Day_Planner.Views
{
    partial class PdfDisplayView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.GenerateInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(12, 12);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(575, 655);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // GenerateInvoice
            // 
            this.GenerateInvoice.Location = new System.Drawing.Point(433, 713);
            this.GenerateInvoice.Name = "GenerateInvoice";
            this.GenerateInvoice.Size = new System.Drawing.Size(144, 48);
            this.GenerateInvoice.TabIndex = 3;
            this.GenerateInvoice.Text = "Generate Invoice";
            this.GenerateInvoice.UseVisualStyleBackColor = true;
            this.GenerateInvoice.Click += new System.EventHandler(this.GenerateInvoice_Click);
            // 
            // PdfDisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 773);
            this.Controls.Add(this.GenerateInvoice);
            this.Controls.Add(this.webBrowser2);
            this.Name = "PdfDisplayView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button GenerateInvoice;
    }
}