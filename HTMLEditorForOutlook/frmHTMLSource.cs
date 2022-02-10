using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorForOutlook
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
            RefreshHtml();
        }

        private void RefreshHtml()
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshHtml();
        }

        private void liveRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHTMLSource_TextChanged(object sender, EventArgs e)
        {
            if (liveRefreshCheckBox.Checked)
            {
                RefreshHtml();
            }
        }
    }
}
