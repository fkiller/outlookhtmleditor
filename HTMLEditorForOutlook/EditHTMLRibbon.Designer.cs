namespace HTMLEditorForOutlook
{
    partial class EditHTMLRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EditHTMLRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdvanced = this.Factory.CreateRibbonTab();
            this.grpSource = this.Factory.CreateRibbonGroup();
            this.btnImportHTML = this.Factory.CreateRibbonButton();
            this.btnHTMLSource = this.Factory.CreateRibbonButton();
            this.grpHelp = this.Factory.CreateRibbonGroup();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.tabAdvanced.SuspendLayout();
            this.grpSource.SuspendLayout();
            this.grpHelp.SuspendLayout();
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Groups.Add(this.grpSource);
            this.tabAdvanced.Groups.Add(this.grpHelp);
            this.tabAdvanced.Label = "Advanced";
            this.tabAdvanced.Name = "tabAdvanced";
            // 
            // grpSource
            // 
            this.grpSource.Items.Add(this.btnImportHTML);
            this.grpSource.Items.Add(this.btnHTMLSource);
            this.grpSource.Label = "Source";
            this.grpSource.Name = "grpSource";
            // 
            // btnImportHTML
            // 
            this.btnImportHTML.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnImportHTML.Image = global::HTMLEditorForOutlook.Properties.Resources.import_html;
            this.btnImportHTML.Label = "Import HTML File";
            this.btnImportHTML.Name = "btnImportHTML";
            this.btnImportHTML.ShowImage = true;
            this.btnImportHTML.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnImportHTML_Click);
            // 
            // btnHTMLSource
            // 
            this.btnHTMLSource.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnHTMLSource.Image = global::HTMLEditorForOutlook.Properties.Resources.html_source;
            this.btnHTMLSource.Label = "Edit HTML Source";
            this.btnHTMLSource.Name = "btnHTMLSource";
            this.btnHTMLSource.ShowImage = true;
            this.btnHTMLSource.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHTMLSource_Click);
            // 
            // grpHelp
            // 
            this.grpHelp.Items.Add(this.btnAbout);
            this.grpHelp.Label = "Help";
            this.grpHelp.Name = "grpHelp";
            // 
            // btnAbout
            // 
            this.btnAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAbout.Image = global::HTMLEditorForOutlook.Properties.Resources.help_about;
            this.btnAbout.Label = "About";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // EditHTMLRibbon
            // 
            this.Name = "EditHTMLRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose";
            this.Tabs.Add(this.tabAdvanced);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EditHTMLRibbon_Load);
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpHelp.ResumeLayout(false);
            this.grpHelp.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabAdvanced;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSource;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImportHTML;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHTMLSource;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;

    }

    partial class ThisRibbonCollection
    {
        internal EditHTMLRibbon EditHTMLRibbon
        {
            get { return this.GetRibbon<EditHTMLRibbon>(); }
        }
    }
}
