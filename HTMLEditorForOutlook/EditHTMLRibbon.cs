using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using System.IO;

namespace HTMLEditorForOutlook
{
    public partial class EditHTMLRibbon
    {
        private void EditHTMLRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnImportHTML_Click(object sender, RibbonControlEventArgs e)
        {
            // Get inspector
            Microsoft.Office.Interop.Outlook.Inspector currentInspector = this.Context as Microsoft.Office.Interop.Outlook.Inspector;
            
            // If inspector hasn't been initialized
            if (currentInspector == null)
            {
                return;
            }

            // Get current mail item from inspector
            Microsoft.Office.Interop.Outlook.MailItem currentMailItem =
                currentInspector.CurrentItem as Microsoft.Office.Interop.Outlook.MailItem;
            if (currentMailItem != null)
            {
                // Open file dialog to import HTML file
                OpenFileDialog dlgOpenHTML = new OpenFileDialog();
                dlgOpenHTML.Filter = "HTML files (*.htm, *.html)|*.htm;*.html|All files (*.*)|*.*";
                dlgOpenHTML.FilterIndex = 1;
                if (dlgOpenHTML.ShowDialog() == DialogResult.OK)
                {
                    // Read a file and put it on body of current email item
                    StreamReader stmReader = new StreamReader(dlgOpenHTML.FileName);
                    currentMailItem.HTMLBody = stmReader.ReadToEnd();
                }
            }
        }

        private void btnHTMLSource_Click(object sender, RibbonControlEventArgs e)
        {
            // Get inspector
            Microsoft.Office.Interop.Outlook.Inspector currentInspector =
    this.Context as Microsoft.Office.Interop.Outlook.Inspector;

            // If inspector hasn't been initialized
            if (currentInspector == null)
            {
                return;
            }

            // Get current mail item from inspector
            Microsoft.Office.Interop.Outlook.MailItem currentMailItem =
                currentInspector.CurrentItem as Microsoft.Office.Interop.Outlook.MailItem;
            if (currentMailItem != null)
            {
                // Init HTML Editor dialog box
                frmHTMLSource dialog = new frmHTMLSource();
                dialog.Context = currentInspector;
                // Set title as an email subject
                dialog.Text = currentMailItem.Subject;
                try
                {
                    // Set up highlight formatting as HTML
                    dialog.txtHTMLSource.SetHighlighting("HTML");
                    // Copy HTML body from current email item
                    dialog.txtHTMLSource.Text = currentMailItem.HTMLBody;
                }
                finally
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            AboutBox dialog = new AboutBox();
            dialog.ShowDialog();
        }


    }
}
