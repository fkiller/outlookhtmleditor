namespace NativeHTMLEmail
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
            this.txtHTMLSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHTMLSource
            // 
            this.txtHTMLSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHTMLSource.Location = new System.Drawing.Point(0, 0);
            this.txtHTMLSource.Multiline = true;
            this.txtHTMLSource.Name = "txtHTMLSource";
            this.txtHTMLSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHTMLSource.Size = new System.Drawing.Size(501, 509);
            this.txtHTMLSource.TabIndex = 0;
            // 
            // frmHTMLSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 509);
            this.Controls.Add(this.txtHTMLSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHTMLSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHTMLSource_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtHTMLSource;


    }
}