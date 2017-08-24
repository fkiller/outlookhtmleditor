namespace HTMLEditorForOutlook
{
    partial class frmHTMLSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHTMLSource));
            this.txtHTMLSource = new ICSharpCode.TextEditor.TextEditorControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.liveRefreshCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHTMLSource
            // 
            this.txtHTMLSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHTMLSource.IsReadOnly = false;
            this.txtHTMLSource.Location = new System.Drawing.Point(0, 27);
            this.txtHTMLSource.Name = "txtHTMLSource";
            this.txtHTMLSource.Size = new System.Drawing.Size(941, 794);
            this.txtHTMLSource.TabIndex = 1;
            this.txtHTMLSource.TextChanged += new System.EventHandler(this.txtHTMLSource_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::HTMLEditorForOutlook.Properties.Resources.refresh;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(66, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // liveRefreshCheckBox
            // 
            this.liveRefreshCheckBox.AutoSize = true;
            this.liveRefreshCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.liveRefreshCheckBox.Location = new System.Drawing.Point(92, 4);
            this.liveRefreshCheckBox.Name = "liveRefreshCheckBox";
            this.liveRefreshCheckBox.Size = new System.Drawing.Size(86, 17);
            this.liveRefreshCheckBox.TabIndex = 3;
            this.liveRefreshCheckBox.Text = "Live Refresh";
            this.liveRefreshCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.liveRefreshCheckBox.UseVisualStyleBackColor = false;
            this.liveRefreshCheckBox.CheckedChanged += new System.EventHandler(this.liveRefreshCheckBox_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmHTMLSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 833);
            this.Controls.Add(this.liveRefreshCheckBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtHTMLSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHTMLSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHTMLSource_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ICSharpCode.TextEditor.TextEditorControl txtHTMLSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox liveRefreshCheckBox;
    }
}