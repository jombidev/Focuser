namespace Focuser
{
    partial class FocuserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocuserMain));
            this.listProc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listProc
            // 
            this.listProc.FormattingEnabled = true;
            this.listProc.ItemHeight = 12;
            this.listProc.Location = new System.Drawing.Point(12, 12);
            this.listProc.Name = "listProc";
            this.listProc.Size = new System.Drawing.Size(436, 256);
            this.listProc.TabIndex = 0;
            // 
            // FocuserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.ControlBox = false;
            this.Controls.Add(this.listProc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FocuserMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Focuser";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FocuserMain_FormClosing);
            this.Load += new System.EventHandler(this.FocuserMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FocuserMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocuserMain_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProc;
    }
}