using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NativeHTMLEmail
{
    public partial class frmHTMLSource : Form
    {
        public frmHTMLSource()
        {
            InitializeComponent();
        }
        private Microsoft.Office.Interop.Outlook.Inspector pContext = null;
        public Microsoft.Office.Interop.Outlook.Inspector Context
        {
            get
            {
                if (pContext!=null)
                {
                    return pContext;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                pContext = value;
            }
        }

        private void frmHTMLSource_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Get inspector
            Microsoft.Office.Interop.Outlook.Inspector currentInspector = this.Context as Microsoft.Office.Interop.Outlook.Inspector;

            if (currentInspector == null)
            {
                // Context hasn't been initialized
                return;
            }

            // Get current mail item from inspector
            Microsoft.Office.Interop.Outlook.MailItem currentMailItem = currentInspector.CurrentItem as Microsoft.Office.Interop.Outlook.MailItem;

            // If mail item exists
            if (currentMailItem != null)
            {
                // Copy HTML code back to mail item
                currentMailItem.HTMLBody = txtHTMLSource.Text;
            }
        }
    }
}
