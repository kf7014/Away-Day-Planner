﻿
namespace Away_Day_Planner.Views
{
    partial class pdfDisplayView
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
            this.generatePDF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // generatePDF
            // 
            this.generatePDF.Location = new System.Drawing.Point(514, 714);
            this.generatePDF.Name = "generatePDF";
            this.generatePDF.Size = new System.Drawing.Size(160, 54);
            this.generatePDF.TabIndex = 1;
            this.generatePDF.Text = "Generate Inital Invoice";
            this.generatePDF.UseVisualStyleBackColor = true;
            this.generatePDF.Click += new System.EventHandler(this.generatePDF_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(662, 684);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // pdfDisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 780);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.generatePDF);
            this.Name = "pdfDisplayView";
            this.Text = "pdfDisplayView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generatePDF;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}